using System;
using System.Xml;
using System.IO;

namespace WpfApp
{
    public class ActionsClass
    {
        public static XmlDocument xmlFile = LoadXML();
        public static string[] default_sceneStrings = new string[4];
        public static string[] sceneStrings = new string[4];
        public static string xmlPath = "";
        public static string bacDeviceID = "";
        public static string bacPointRefSensor = "";
        public static string bacPointRefPIC = "";
        public static string scenePointID = "";

        

        public static XmlDocument LoadXML(string xmlFilePath = "C:\\Users\\joslynk\\Documents\\SourceTree\\MVM-lighting\\template.xml")
        {
            XmlDocument doc = new XmlDocument();

            if ((File.Exists(xmlFilePath)) && (new FileInfo(xmlFilePath).Length != 0))
            {
                doc.Load(xmlFilePath);
            }

            return doc;
        }

        //output the string that contains the property value 
        public static string displaybacDevice(XmlDocument doc, string name, string property)
        {
            XmlNodeList list = doc.GetElementsByTagName("bacDevice");
            string[] properties = new string[] { "id", "devInst", "macAddr", "devName" }; //don't think i use this
            string output = "";
            int hex2int = 0;

            for (int i = 0; i < list.Count; i++)
            {
                XmlNode node = list[i];
                String devName = node.Attributes["devName"].InnerText;

                if (node != null)
                {
                    //if devName is the same as name specified
                    if ((devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) && (property != null))
                    {
                        bacDeviceID = node.Attributes["id"].InnerText; //gen0x00a00005
                        output = node.Attributes[property].InnerText;
                        if (property.CompareTo("macAddr") >= 0)
                        {
                            hex2int = Convert.ToInt32(output, 16);
                            output = hex2int.ToString();
                        }

                    }
                }
            }

            
            return output;
        }

        public static void findDeviceConnected()
        {
            XmlNodeList list = xmlFile.GetElementsByTagName("treeElement");
            
            bool done = false;
            int i = 0;

            while ((i < list.Count) && (done == false))
            {
                XmlNode node = list[i];
                if (node.Attributes["name"].InnerText.Equals("Client Mappings"))
                {
                    XmlNode deviceNode = node.FirstChild;

                    while (deviceNode != null)
                    {
                        //Find sensor bacPointRef
                        if (deviceNode.Attributes["name"].InnerText.IndexOf("sensor", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            XmlNode propertyNode = deviceNode.FirstChild;

                            while (propertyNode != null)
                            {
                                if (propertyNode.Attributes["name"].InnerText.Equals("Occupancy Status_Read"))
                                {
                                    XmlNode pointNode = propertyNode.FirstChild;

                                    while (pointNode != null)
                                    {
                                        if (pointNode.Name.Equals("bacMapping"))
                                        {
                                            bacPointRefSensor = pointNode.Attributes["bacPointRef"].InnerText; //gen0x00800001
                                        }
                                        pointNode = pointNode.NextSibling;
                                    }
                                }
                                propertyNode = propertyNode.NextSibling;
                            }
                        }

                        //Find PIC bacPointRef
                        if (deviceNode.Attributes["name"].InnerText.IndexOf("pic", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            XmlNode propertyNode = deviceNode.FirstChild;

                            while (propertyNode != null)
                            {
                                if (propertyNode.Attributes["name"].InnerText.Equals("Light Scene_Value"))
                                {
                                    scenePointID = propertyNode.Attributes["id"].InnerText;
                                    XmlNode pointNode = propertyNode.FirstChild;

                                    while (pointNode != null)
                                    {
                                        if (pointNode.Name.Equals("bacMapping"))
                                        {
                                            bacPointRefPIC = pointNode.Attributes["bacPointRef"].InnerText;
                                        }
                                        pointNode = pointNode.NextSibling;
                                    }

                                }
                                propertyNode = propertyNode.NextSibling;
                            }
                        }

                        if ((!string.IsNullOrEmpty(bacPointRefPIC)) && (!string.IsNullOrEmpty(bacPointRefSensor)))
                        {
                            done = true;
                        }
                        deviceNode = deviceNode.NextSibling;
                    }
                }
                i++;
                
            }
        }

        public static void displaySceneList(XmlDocument doc)
        {
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName("LvTextCtrl");
            int j = 0;

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string name = lvTextNode.Attributes["name"].InnerText;
                    string UID = "";

                    while (childNode != null)
                    {
                        if (name.Contains("Scene"))
                        {
                            if (childNode.Name == "dpList")
                            {
                                XmlNode lvDataPoint = childNode.FirstChild;
                                UID = lvDataPoint.Attributes["UID"].InnerText;
                            }
                            if (UID.Equals(scenePointID))
                            {
                                if (childNode.Name.Contains("text"))
                                {
                                    default_sceneStrings[j] = childNode.InnerText;
                                    sceneStrings[j] = childNode.InnerText;
                                    j++;
                                }

                            }
                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }

        }

        

        public static void saveSceneTitle(XmlDocument doc)
        {
            int index = 0;
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName("LvTextCtrl");

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string name = lvTextNode.Attributes["name"].InnerText;
                    string UID = "";

                    while (childNode != null)
                    {
                        if (childNode.Name == "dpList")
                        {
                            XmlNode lvDataPoint = childNode.FirstChild;
                            UID = lvDataPoint.Attributes["UID"].InnerText;
                        }
                        else if ((UID.Equals(scenePointID)) && (childNode.Name == "text") && (name.Contains("Scene")) && (index < sceneStrings.GetLength(0)))
                        {
                            childNode.InnerText = sceneStrings[index];
                            index++;

                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }
        }

        public static void saveMACAddr(XmlDocument doc, string name, string devInst, string prop, string newValue)
        {
            int int2hex = Int32.Parse(newValue);

            if (doc != null)
            {
                XmlNodeList list = doc.GetElementsByTagName("bacDevice");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNode node = list[i];
                    String devName = node.Attributes["devName"].InnerText;
                    if (devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        switch (prop)
                        {
                            case "macAddr":
                                if (devInst.Equals(node.Attributes["devInst"].InnerText))
                                {
                                    node.Attributes[prop].InnerText = int2hex.ToString("X2");
                                }
                                break;
                            case "devInst":
                                node.Attributes[prop].InnerText = newValue;
                                break;
                            default:
                                break;
                        }

                    }
                }
            }


        }

        public static void setScene(int index, string scene)
        {
            sceneStrings[index] = scene;
        }

        public static string getScene(int index)
        {
            return sceneStrings[index];
        }

        public static void setdefaultScene(int index, string scene)
        {
            default_sceneStrings[index] = scene;
        }

        public static string getdefaultScene(int index)
        {
            return default_sceneStrings[index];
        }

        public static XmlDocument getXmlDocument()
        {
            return xmlFile;
        }

        public static void setXmlDocument(XmlDocument doc)
        {
            xmlFile = doc;
        }
    }
}
