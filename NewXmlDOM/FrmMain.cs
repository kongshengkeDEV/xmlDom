using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace NewXmlDOM
{
    public partial class FrmMain : Form
    {
        private XmlDocument xmlDoc = null;
        private Hashtable ht = null;
        private XmlNode copied = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            ht = new Hashtable();
        }

        private void trvXmlNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            XmlNode xn = (XmlNode)ht[e.Node];
            txtXmlName.Text = xn.Name;
            if (xn.ChildNodes.Count <= 1)
            {
                txtXmlValue.Text = xn.InnerText;
            }
            else
            {
                txtXmlValue.Text = "--";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件:";
            ofd.Filter = "Xml;Xsl;Xsd文件(*.xml;*.xsd;*.xsl)|*.xml;*.xsd;*.xsl;|C#文件(*.cs)|*.cs;|文本文件(*.txt)|*.txt;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                if (File.Exists(fileName))
                {
                    xmlDoc.Load(fileName);
                    lblDocName.Text = new FileInfo(fileName).Name;
                    SelectXmlNodes();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            if (copied == null)
            {
                XmlNode newChild = xmlDoc.CreateNode(XmlNodeType.Element, txtXmlName.Text.Trim(), xmlDoc.NamespaceURI);
                newChild.InnerText = txtXmlValue.Text;
                xn.AppendChild(newChild);
            }
            else
            {
                xn.AppendChild(copied);
                copied = null;
            }
            SelectXmlNodes();
        }

        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            XmlNode newChild = xmlDoc.CreateNode(XmlNodeType.Element, txtXmlName.Text.Trim(), xmlDoc.NamespaceURI);
            newChild.InnerText = txtXmlValue.Text;
            xn.ParentNode.InsertAfter(newChild, xn);
            SelectXmlNodes();
        }

        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            XmlNode newChild = xmlDoc.CreateNode(XmlNodeType.Element, txtXmlName.Text.Trim(), xmlDoc.NamespaceURI);
            newChild.InnerText = txtXmlValue.Text;
            xn.ParentNode.InsertBefore(newChild, xn);
            SelectXmlNodes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            xn.InnerText = txtXmlValue.Text;
            MessageBox.Show("已更新!");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            copied = ((XmlNode)ht[trvXmlNodes.SelectedNode]).Clone();
            MessageBox.Show("节点已拷贝成功!");
        }

        private void btnInsertAttribute_Click(object sender, EventArgs e)
        {
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            XmlNode newChild = xmlDoc.CreateNode(XmlNodeType.Attribute, txtXmlName.Text.Trim(), xmlDoc.NamespaceURI);
            newChild.Value = txtXmlValue.Text;//属性可以用Value和InnerText属性赋值..元素类型不能用Value赋值!
            xn.Attributes.Append((XmlAttribute)newChild);
            SelectXmlNodes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (trvXmlNodes.SelectedNode == null)
            {
                MessageBox.Show("已删除所有节点!");
                return;
            }
            XmlNode xn = (XmlNode)ht[trvXmlNodes.SelectedNode];
            if (xn.NodeType == XmlNodeType.Element)
            {
                xn.ParentNode.RemoveChild(xn);
                trvXmlNodes.Nodes.Remove(trvXmlNodes.SelectedNode);
            }
            else if (xn.NodeType == XmlNodeType.Attribute)
            {
                XmlAttribute xa = (XmlAttribute)xn;
                xa.OwnerElement.Attributes.Remove(xa);
                trvXmlNodes.Nodes.Remove(trvXmlNodes.SelectedNode);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            trvXmlNodes.Nodes.Clear();
        }

        //递归调用，带2个参数，第一个参数--指定的控件,第二个参数--指定的操作对象
        private void LoadXmlNodes(TreeNodeCollection treeNodes, XmlNode xmlNode)
        {
            switch (xmlNode.NodeType)
            {
                case XmlNodeType.Element:
                    TreeNode treeNode = new TreeNode(xmlNode.Name);
                    treeNodes.Add(treeNode);
                    ht.Add(treeNode, xmlNode);

                    foreach (XmlAttribute xmlAttr in xmlNode.Attributes)
                    {
                        TreeNode attrNode = new TreeNode("@" + xmlAttr.Name);
                        treeNode.Nodes.Add(attrNode);
                        ht.Add(attrNode, xmlAttr);
                    }

                    foreach (XmlNode xn in xmlNode.ChildNodes)
                    {
                        LoadXmlNodes(treeNode.Nodes, xn);
                    }
                    break;
                case XmlNodeType.Entity:
                    break;
                case XmlNodeType.Text:
                    break;
                case XmlNodeType.Comment:
                    break;
                default:
                    break;
            }
        }

        private void SelectXmlNodes()
        {
            trvXmlNodes.Nodes.Clear();
            LoadXmlNodes(trvXmlNodes.Nodes, xmlDoc.DocumentElement);
            trvXmlNodes.ExpandAll();
            trvXmlNodes.SelectedNode = trvXmlNodes.Nodes[0];
        }

    }
}