using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Guide
{
    public partial class ReferenceForm : Form
    {
        private Dictionary<string, ReferenceDetail> references;
        public ReferenceForm()
        {
            InitializeComponent();
        }

        private void ReferenceForm_Load(object sender, EventArgs e)
        {
            string filePath = "references.json"; // Ensure the file is in the output directory
            references = ReferenceLoader.LoadReferences(filePath);

            // Populate the ListBox with topics
            listBoxRefTopics.Items.Clear();
            foreach (string topic in references.Keys)
            {
                listBoxRefTopics.Items.Add(topic);
            }
        }

        private void listBoxRefTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRefTopics.SelectedItem != null)
            {
                string topic = listBoxRefTopics.SelectedItem.ToString();
                if (references != null && references.ContainsKey(topic))
                {
                    ReferenceDetail detail = references[topic];
                    string output =
                        "Key Concepts:\n" + detail.KeyConcepts + "\n\n" +
                        "Examples:\n" + detail.Examples + "\n\n" +
                        "Additional Resources:\n" + detail.AdditionalResources;
                    richTextBoxReference.Text = output;
                }
                else
                {
                    richTextBoxReference.Text = "No reference details available for this topic.";
                }
            }
        }
    }
}
