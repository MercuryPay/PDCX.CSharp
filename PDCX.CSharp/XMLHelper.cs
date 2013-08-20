using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace PDCX.CSharp
{
    public static class XMLHelper
    {
        public static XDocument BuildXMLRequest(this Dictionary<string, object> dictionary, string containerTag)
        {
            var tStream = new Dictionary<string, object>();
            tStream.Add(containerTag, dictionary);
            return XMLHelper.ToXml(tStream, "TStream");
        }

        public static Dictionary<string, string> ParseXMLResponse(string xmlResponse)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlResponse);
            TraverseNodes(doc.ChildNodes, dictionary);
            return dictionary;
        }


        private static XDocument ToXml(this Dictionary<string, object> dictionary, string rootElementName)
        {
            var doc = new XDocument();
            var dataRoot = new XElement(rootElementName);
            var containerList = new List<string>();

            foreach (var kvp in dictionary)
            {
                dataRoot.Add(kvp.SerializeKVP());
            }

            doc.Add(dataRoot);
            return doc;
        }

        private static XElement SerializeKVP(this KeyValuePair<string, object> kvp)
        {
            var xElem = new XElement(kvp.Key);
            if (kvp.Value is Dictionary<string, object>)
            {
                foreach (var key in (kvp.Value as Dictionary<string, object>))
                {
                    xElem.Add(key.SerializeKVP());
                }
            }
            else
            {
                if (kvp.Value is decimal)
                {
                    xElem.Value = kvp.Value == null ? string.Empty : ((decimal)kvp.Value).ToString("0.00");
                }
                else if (kvp.Value is double)
                {
                    xElem.Value = kvp.Value == null ? string.Empty : ((double)kvp.Value).ToString("0.00");
                }
                else if (kvp.Value is float)
                {
                    xElem.Value = kvp.Value == null ? string.Empty : ((float)kvp.Value).ToString("0.00");
                }
                else
                {
                    xElem.Value = kvp.Value == null ? string.Empty : kvp.Value.ToString();
                }
            }

            return xElem;
        }

        private static void TraverseNodes(XmlNodeList nodes, Dictionary<string, string> dict)
        {
            foreach (XmlNode node in nodes)
            {
                if (node.HasChildNodes)
                {
                    TraverseNodes(node.ChildNodes, dict);
                }
                else
                {
                    if (node.NodeType == XmlNodeType.Text
                        && !dict.ContainsKey(node.ParentNode.Name))
                    {
                        dict.Add(node.ParentNode.Name, node.InnerText);
                    }
                }
            }
        }
    }
}
