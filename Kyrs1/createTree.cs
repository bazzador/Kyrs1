using System;
using System.Windows.Forms;

namespace Kyrs1
{
    public partial class createTree : Form
    {
        public event EventHandler<TreeEventArgs> TreeCreated;

        public createTree()
        {
            InitializeComponent();
        }

        public class Tree
        {
            public string Name { get; set; }
            public int AmountOfBranches { get; set; }

            public Tree(string name, int amountOfBranches)
            {
                Name = name;
                AmountOfBranches = amountOfBranches;
            }
        }

        public class TreeEventArgs : EventArgs
        {
            public Tree Tree { get; }

            public TreeEventArgs(Tree tree)
            {
                Tree = tree;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree(nameText.Text, int.Parse(amount.Text));
            TreeCreated?.Invoke(this, new TreeEventArgs(tree));
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(amount.Text))
            {
                // Створюємо нову гілку з введеними даними
                Tree tree = new Tree(nameText.Text, int.Parse(amount.Text));

                // Додаємо назву гілки у listView1
                for (int i = 0; i < tree.AmountOfBranches; i++)
                {
                    listView1.Items.Add($"Вітка {i + 1}");
                }
            } 
            else
            {
                // Виводимо повідомлення, якщо дані не введені
                MessageBox.Show("Будь ласка, введіть назву та кількість гілок.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
