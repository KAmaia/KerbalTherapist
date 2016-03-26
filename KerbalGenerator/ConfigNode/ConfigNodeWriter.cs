/*
 * All ConfigNode Related Code is thanks to: darklight in #kspmodders on the esper.net IRC network.  
 * This source code is in the public domain, and any section of ConfigNode related code found in this project,
 * with this header is released freely into the public domain with no regard to any other license applied to this
 * project.  
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConfigNodeParser
{
    public class ConfigNodeWriter
    {
        public static string ConfigNodeToString(ConfigNode node, int indent)
        {
            string prependTabs = new string('\t', indent);
            StringBuilder returnStringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in node.values)
            {
                returnStringBuilder.Append(prependTabs);
                returnStringBuilder.Append(kvp.Key);
                returnStringBuilder.Append(" = ");
                if (kvp.Value != null)
                {
                    returnStringBuilder.Append(kvp.Value);
                }
                returnStringBuilder.AppendLine();
            }
            foreach (ConfigNode childNode in node.nodes)
            {
                if (childNode.name == null)
                {
                    returnStringBuilder.AppendLine(prependTabs);
                }
                else
                {
                    returnStringBuilder.Append(prependTabs);
                    returnStringBuilder.AppendLine(childNode.name);
                    returnStringBuilder.Append(prependTabs);
                    returnStringBuilder.AppendLine("{");
                }
                returnStringBuilder.Append(ConfigNodeToString(childNode, indent + 1));
                returnStringBuilder.Append(prependTabs);
                returnStringBuilder.AppendLine("}");
            }
            return returnStringBuilder.ToString();
        }

        public static string ConfigNodeToString(ConfigNode node)
        {
            return ConfigNodeToString(node, 0);
        }

        public static bool FileToConfigNode(ConfigNode node, string fileName, string prependHeader)
        {
            string configNodeText = ConfigNodeToString(node);
            if (prependHeader != null)
            {
                configNodeText = prependHeader + configNodeText;
            }
            File.WriteAllText(fileName, configNodeText);
            return true;
        }
    }
}

