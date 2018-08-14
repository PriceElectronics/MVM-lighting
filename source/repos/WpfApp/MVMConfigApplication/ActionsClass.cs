using System;
using System.Xml;
using System.IO;

namespace MVMConfigApplication
{
    public class ActionsClass
    {
        public static XmlDocument xmlFile = loadDefaultXML();
        public static int userSceneNum = 4;
        public static string[] default_sceneStrings = new string[userSceneNum];
        public static string[] sceneStrings = new string[userSceneNum];

        public static string bacDeviceID = "";
        public static string bacPointRefSensor = "";
        public static string bacPointRefPIC = "";
        public static string scenePointID = "";

        public static string device_instance = AC_LocalResource_Folder.LVisVar.device_instance;
        public static string MAC = AC_LocalResource_Folder.LVisVar.MAC;
        public static string ID = AC_LocalResource_Folder.LVisVar.ID;
        public static string device_name = AC_LocalResource_Folder.LVisVar.device_name;
        public static string bacDeviceTag = AC_LocalResource_Folder.LVisVar.bacDeviceTag;
        public static string name = AC_LocalResource_Folder.LVisVar.name;
        public static string lv = AC_LocalResource_Folder.LVisVar.lv;

        public static XmlDocument loadDefaultXML()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            XmlDocument doc = new XmlDocument();

            doc.Load(a.GetManifestResourceStream("MVMConfigApplication.Resources.template.xml"));

            return doc;
        }

        public static XmlDocument LoadXML(string xmlFilePath)
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
            XmlNodeList list = doc.GetElementsByTagName(bacDeviceTag);
            string output = "";
            int hex2int = 0;

            for (int i = 0; i < list.Count; i++)
            {
                XmlNode node = list[i];
                String devName = node.Attributes[device_name].InnerText;

                if (node != null)
                {
                    //if devName is the same as name specified
                    if ((devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) && (property != null))
                    {
                        bacDeviceID = node.Attributes[ID].InnerText; 
                        output = node.Attributes[property].InnerText;
                        if (property.CompareTo(MAC) >= 0)
                        {
                            hex2int = Convert.ToInt32(output, 16);
                            output = hex2int.ToString();
                        }

                    }
                }
            }

            
            return output;
        }

        public static void findDeviceConnected(XmlDocument doc)
        {
            XmlNodeList list = doc.GetElementsByTagName("treeElement");
            
            bool done = false;
            int i = 0;

            while ((i < list.Count) && (done == false))
            {
                done = getElement_ClientMapping(list, i, done);
                i++;
                
            }
        }

        public static bool getElement_ClientMapping(XmlNodeList list, int index, bool done)
        {
            XmlNode node = list[index];
            if (node.Attributes[name].InnerText.Equals("Client Mappings"))
            {
                XmlNode deviceNode = node.FirstChild;

                while (deviceNode != null)
                {
                    bacPointRefPIC = setRefID(deviceNode, "pic", "Light Scene_Value",bacPointRefPIC);
                    bacPointRefSensor = setRefID(deviceNode, "sensor", "Occupancy Status_Read", bacPointRefSensor);

                    if ((!string.IsNullOrEmpty(bacPointRefPIC)) && (!string.IsNullOrEmpty(bacPointRefSensor)))
                    {
                        done = true;
                    }
                    deviceNode = deviceNode.NextSibling;
                }
            }
            return done;
        }

        public static string setRefID(XmlNode deviceNode, string bacDevice, string propertyNodeName, string refPointID)
        {
            if (deviceNode.Attributes[name].InnerText.IndexOf(bacDevice, StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                XmlNode propertyNode = deviceNode.FirstChild;

                while (propertyNode != null)
                {
                    if (propertyNode.Attributes[name].InnerText.Equals(propertyNodeName))
                    {
                        XmlNode pointNode = propertyNode.FirstChild;

                        if (propertyNodeName.Equals("Light Scene_Value"))
                        {
                            scenePointID = propertyNode.Attributes[ID].InnerText;
                        }

                        while (pointNode != null)
                        {
                            if (pointNode.Name.Equals("bacMapping"))
                            {
                                refPointID = pointNode.Attributes["bacPointRef"].InnerText;
                            }
                            pointNode = pointNode.NextSibling;
                        }

                    }
                    propertyNode = propertyNode.NextSibling;
                }
            }

            return refPointID;
        }

        public static void displaySceneList(XmlDocument doc)
        {
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName(lv);
            int j = 0;

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string sceneName = lvTextNode.Attributes[name].InnerText;
                    string UID = "";

                    while (childNode != null)
                    {
                        if (sceneName.Contains("Scene"))
                        {
                            if (childNode.Name.Contains("dpList"))
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
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName(lv);

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string sceneName = lvTextNode.Attributes[name].InnerText;
                    string UID = "";

                    while (childNode != null)
                    {
                        if (childNode.Name == "dpList")
                        {
                            XmlNode lvDataPoint = childNode.FirstChild;
                            UID = lvDataPoint.Attributes["UID"].InnerText;
                        }
                        else if ((UID.Equals(scenePointID)) && (childNode.Name == "text") && (sceneName.Contains("Scene")) && (index < sceneStrings.GetLength(0)))
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
                XmlNodeList list = doc.GetElementsByTagName(bacDeviceTag);

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNode node = list[i];
                    String devName = node.Attributes[device_name].InnerText;
                    if (devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        switch (prop)
                        {
                            case "macAddr":
                                if (devInst.Equals(node.Attributes[device_instance].InnerText)) //Check if device instance is the same for both
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
