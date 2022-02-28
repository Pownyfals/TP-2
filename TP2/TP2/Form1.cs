namespace TP2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = "Hallo " + textBox.Text;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}