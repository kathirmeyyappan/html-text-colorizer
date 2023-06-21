using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextColorizer
{
    public partial class ColorizerGUI : Form
    {
        public ColorizerGUI() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outputText = Input.Text;

            // putting input text through the specified function to yield HTML

            if (Input.Text.Length != 0 && comboBox1.SelectedItem == "Rainbow Alternating")
            {
                var inputText = new InputText(Input.Text);
                outputText = inputText.GetRainbowAltHTML();
            }

            else if (Input.Text.Length != 0 && comboBox1.SelectedItem == "Custom Alternating")
            {
                var inputText = new InputText(Input.Text);
                var colors = new List<Color>();
                foreach (CheckBox check in new CheckBox[] { colorBox1, colorBox2, colorBox3,
                    colorBox4, colorBox5, colorBox6 })
                {
                    if (check.Checked)
                        colors.Add(check.ForeColor);
                }

                outputText = (colors.Count > 0) ?
                    inputText.GetCustomAltHTML(colors) : "SELECT AT LEAST 1 COLOR";
            }

            else if (Input.Text.Length != 0 && comboBox1.SelectedItem == "Custom Shift")
            {
                var inputText = new InputText(Input.Text);
                var colors = new List<Color>();
                foreach (CheckBox check in new CheckBox[] { colorBox1, colorBox2, colorBox3,
                    colorBox4, colorBox5, colorBox6 })
                {
                    if (check.Checked)
                        colors.Add(check.ForeColor);
                }

                outputText = (colors.Count > 0) ?
                    inputText.GetCustomShiftHTML(colors) : "SELECT AT LEAST 1 COLOR";
            }

            else if (Input.Text.Length != 0 && comboBox1.SelectedItem == "Rainbow Shift")
            {
                var inputText = new InputText(Input.Text);
                outputText = inputText.GetRainbowShiftHTML();
            }

            // adding bold and italics
            outputText = boldBox.Checked ? $"<b>{outputText}</b>" : outputText;
            outputText = italicsBox.Checked ? $"<i>{outputText}</i>" : outputText;

            Output.Text = htmlPreview.DocumentText = outputText;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checkBoxBool = (comboBox1.SelectedItem.ToString() == "Custom Shift" || 
                comboBox1.SelectedItem.ToString() == "Custom Alternating") ? true : false;
            colorBox1.Visible = colorBox2.Visible = colorBox3.Visible = colorBox4.Visible =
                colorBox5.Visible = colorBox6.Visible = checkBoxBool;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox1.Checked && colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorBox1.ForeColor = colorDialog1.Color;
                colorBox1.Text = colorDialog1.Color.IsNamedColor ?
                    colorDialog1.Color.Name : $"#{colorDialog1.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox1.Checked)
            {
                colorBox1.ForeColor = Color.Black;
                colorBox1.Text = "Unused Color";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox2.Checked && colorDialog2.ShowDialog() == DialogResult.OK)
            {
                colorBox2.ForeColor = colorDialog2.Color;
                colorBox2.Text = colorDialog2.Color.IsNamedColor ? 
                    colorDialog2.Color.Name : $"#{colorDialog2.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox2.Checked)
            {
                colorBox2.ForeColor = Color.Black;
                colorBox2.Text = "Unused Color";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox3.Checked && colorDialog3.ShowDialog() == DialogResult.OK)
            {
                colorBox3.ForeColor = colorDialog3.Color;
                colorBox3.Text = colorDialog3.Color.IsNamedColor ?
                    colorDialog3.Color.Name : $"#{colorDialog3.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox3.Checked)
            {
                colorBox3.ForeColor = Color.Black;
                colorBox3.Text = "Unused Color";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox4.Checked && colorDialog4.ShowDialog() == DialogResult.OK)
            {
                colorBox4.ForeColor = colorDialog4.Color;
                colorBox4.Text = colorDialog4.Color.IsNamedColor ?
                    colorDialog4.Color.Name : $"#{colorDialog4.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox4.Checked)
            {
                colorBox4.ForeColor = Color.Black;
                colorBox4.Text = "Unused Color";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox5.Checked && colorDialog5.ShowDialog() == DialogResult.OK)
            {
                colorBox5.ForeColor = colorDialog5.Color;
                colorBox5.Text = colorDialog5.Color.IsNamedColor ?
                    colorDialog5.Color.Name : $"#{colorDialog5.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox5.Checked)
            {
                colorBox5.ForeColor = Color.Black;
                colorBox5.Text = "Unused Color";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (colorBox6.Checked && colorDialog6.ShowDialog() == DialogResult.OK)
            {
                colorBox6.ForeColor = colorDialog6.Color;
                colorBox6.Text = colorDialog6.Color.IsNamedColor ?
                    colorDialog6.Color.Name : $"#{colorDialog6.Color.Name.Substring(2, 6)}";
            }
            else if (!colorBox6.Checked)
            {
                colorBox6.ForeColor = Color.Black;
                colorBox6.Text = "Unused Color";
            }
        }
    }
}
