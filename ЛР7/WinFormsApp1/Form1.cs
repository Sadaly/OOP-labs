using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void óïîðÿäî÷èòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void RedEclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Circle";
            fc.color = "Red";
            fc.MdiParent = this;
            fc.Show();
        }

        private void GreenEclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Circle";
            fc.color = "Green";
            fc.MdiParent = this;
            fc.Show();
        }

        private void BlueEclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Circle";
            fc.color = "Blue";
            fc.MdiParent = this;
            fc.Show();
        }

        private void RedRecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Square";
            fc.color = "Red";
            fc.MdiParent = this;
            fc.Show();
        }

        private void GreenRecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Square";
            fc.color = "Green";
            fc.MdiParent = this;
            fc.Show();
        }

        private void BlueRecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Square";
            fc.color = "Blue";
            fc.MdiParent = this;
            fc.Show();
        }

        private void RedTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Triangle";
            fc.color = "Red";
            fc.MdiParent = this;
            fc.Show();
        }

        private void GreenTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Triangle";
            fc.color = "Green";
            fc.MdiParent = this;
            fc.Show();
        }

        private void BlueTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild fc = new FormChild();
            fc.figure = "Triangle";
            fc.color = "Blue";
            fc.MdiParent = this;
            fc.Show();
        }
    }
}