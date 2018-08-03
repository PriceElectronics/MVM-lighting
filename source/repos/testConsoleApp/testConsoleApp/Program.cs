using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace testConsoleApp
{
    class Program
    {
        public enum Functions
        {
            displayList,
            changeMAC,
            modifyString,
            back,
            EXIT

        }

        static string xmlFilePath = "";
        static XmlDocument currentXMLfile = loadXML(xmlFilePath);
        static int length = Enum.GetNames(typeof(Functions)).Length;
        
        static int top = 0; //Cursor position
        static int pos = 0; //List row position 
        static int column = 0; //List column position (if applicable)

        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit):");
            Console.WriteLine();
            do
            {
                line = Console.ReadLine();
                if (line != null)
                {
                    if (line == "app")
                    {
                        isValidPath();

                        
                        
                        selectFunc(top); // this is a do-while loop

                        
                    }
                }
            } while (line != null);
        }

        static void isValidPath() //need to come out from here to go to the next application 
        {
            setTopCursorPosition(length);
            string XMLfile;
            do
            {
                Console.WriteLine("\r\nEnter the path of XML file (/path/*.xml)");
                XMLfile = Console.ReadLine();
                if (File.Exists(XMLfile))
                {
                    Console.WriteLine("Processed file '{0}'.", XMLfile);
                    loadXML(XMLfile);
                    goto Done;
                }
                else
                {
                    Console.WriteLine("\r\nThis is not a valid XML path, exit?");
                    if (Console.ReadLine() == "yes")
                    {
                        goto Done;
                    }
                }
            } while ((!File.Exists(XMLfile)) || (Console.ReadLine() == "no"));

        Done:
            Console.WriteLine("\r\nLoad XML complete. What to do?");
            returnToMenu();
        }

        


        static void selectFunc(int top)
        {
            ConsoleKeyInfo input;

            Console.CursorVisible = true;
            Console.CursorSize = 100;
            Console.SetCursorPosition(0, top);
            

            do
            {              
                input = navigateMenu(getLength());

                if (input.Key == ConsoleKey.Enter)
                {
                    executeMenu(getRowArrowPos());
                }

            } while (input.Key != ConsoleKey.Escape);
        }

        
        
        static ConsoleKeyInfo navigateMenu(int length)
        {
            ConsoleKeyInfo input;
            int maxLength = length - 1;
            bool select = false;
            int arrowRowPosition = getRowArrowPos();
            int arrowColumnPosition = getColumnPos();

            do
            {
                Console.SetCursorPosition(0, top + arrowRowPosition);

                input = Console.ReadKey(true);

                //Console.Write(Enum.Parse(typeof(Functions), arrowPosition.ToString()));

                if (input.Key == ConsoleKey.DownArrow) //Navigate down the menu
                {

                    if ((arrowRowPosition >= 0) && (arrowRowPosition < maxLength))
                    {
                        arrowRowPosition++;
                    } 
                    select = true;

                }
                else if (input.Key == ConsoleKey.UpArrow) //Navigate up the menu
                {
                    if ((arrowRowPosition > 0) && (arrowRowPosition <= maxLength))
                    {
                        arrowRowPosition--;

                    } 
                    select = true;
                } else if (input.Key == ConsoleKey.LeftArrow)
                {
                    if ((arrowColumnPosition >= 0) && (arrowColumnPosition < maxLength))
                    {
                        arrowColumnPosition++;
                    }
                    select = true;

                } else if (input.Key == ConsoleKey.RightArrow)
                { }
                    
                




            } while ((input.Key != ConsoleKey.Enter) && (select == false)) ;

            
            setRowArrowPos(arrowRowPosition);

            return input;

        }

        static Functions executeMenu(int position)
        {
            Functions func = (Functions)(position);
            setTopCursorPosition(length);
            Console.SetCursorPosition(0, getTopCursorPosition());

            switch (func)
            {
                case (Functions.displayList):
                    displayInnerText("bacDevice", new string[] { "devName", "devInst", "macAddr" });
                    break;
                case (Functions.changeMAC):
                    break;
                case (Functions.modifyString):
                    displaySceneList(currentXMLfile);
                    break;
                case (Functions.back):
                    isValidPath();
                    break;
                case (Functions.EXIT):
                    System.Environment.Exit(0);
                    break;
                default:
                    selectFunc(top);
                    break;
            }

            return func;
        }

        static XmlDocument loadXML(string xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists(xmlPath))
            {
                xmlFilePath = xmlPath;
                doc.Load(xmlPath);
                currentXMLfile = doc;
            }

            return doc;
        }

        static void displaySceneList(XmlDocument doc)
        {
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName("LvTextCtrl");
            setLength(lvTextCtrl_list.Count);

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string name = lvTextNode.Attributes["name"].InnerText;

                    while (childNode != null)
                    {
                        if (childNode.Name == "dpList")
                        {
                            XmlNode lvDataPoint = childNode.FirstChild;
                            //Console.WriteLine("name: " + lvDataPoint.Attributes["name"].InnerText + '\t' + 
                            //    "UID: " + lvDataPoint.Attributes["UID"].InnerText);

                        }
                        else if ((childNode.Name == "text") && (name.Contains("Scene")))
                        {

                            Console.WriteLine(name + ": " + childNode.InnerText);
                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }

        }

        static void displayInnerText(string parentNodeName, string[] properties)
        {
            XmlNodeList list = currentXMLfile.GetElementsByTagName(parentNodeName);
            length = list.Count;
            createHeader(properties);
            string[,] outputStr = new string[(list.Count + 1), (properties.GetLength(0) + 1)];

            for (int i = 0; i < length; i++)
            {
                outputStr[i, 0]= " Device" + String.Format("{0,3}", i) + ": ";
                XmlNode node = list[i];

                if (node != null)
                {
                    for (int j = 0; j < properties.GetLength(0); j++)
                    {
                        outputStr[i,j] += $"{ (node.Attributes[properties[j]].InnerText),20}";
                        Console.Write(outputStr[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            outputStr[list.Count,0] += "Back";

        }

        static void createHeader(string[] properties)
        {
            string header = "";
            header += header.PadRight(10);

            for (int i = 0; i < properties.GetLength(0); i++)
            {
                header += "|";
                header += (properties[i].PadRight(20));
            }
            Console.WriteLine(header);  // Displays "|properties[i]  |".
            length++;
        }

        static void returnToMenu()
        {
            top = Console.CursorTop;
            Console.Write("\r{0}    ", printXmlFunction());
        }

        static string printXmlFunction()
        {
            var values = Enum.GetNames(typeof(Functions));
            string toPrint = "";

            foreach (var value in values)
            {
                toPrint += (value + "\n");
            }
            return toPrint;
        }

        static int getRowArrowPos()
        {
            return pos;
        }

        static void setRowArrowPos(int value)
        {
            pos = value;
        }

        static int getColumnPos()
        {
            return column;
        }

        static void setColumnPos(int value)
        {
            column = value;
        }

        static int getTopCursorPosition()
        {
            return top;
        }

        static void setTopCursorPosition(int value)
        {
            top += (value + 1) ;
        }

        static int getLength()
        {
            return length;
        }

        static void setLength(int value)
        {
            length = value;
        }

        
    }
}

