using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);

            
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name+" "+ method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString()); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
