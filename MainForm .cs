using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResizableForm
{
	public partial class MainForm : Form
	{
		private TextBox textBox;
		private Button resizeButton;

		private Panel navigationPanel;
		private Panel workspacePanel;

		public MainForm()
		{
			InitializeComponent();
			InitializeUI();
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resizable Form";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.ResumeLayout(false);
		}

		private void InitializeUI()
		{
			textBox = new TextBox();
			textBox.Location = new Point(10, 10);
			textBox.Width = ClientSize.Width / 2 - 15;
			textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.Controls.Add(textBox);

			resizeButton = new Button();
			resizeButton.Text = "Resize";
			resizeButton.Location = new Point(textBox.Width + 20, 10);
			resizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			resizeButton.Click += ResizeButton_Click;
			this.Controls.Add(resizeButton);

			navigationPanel = new Panel();
			navigationPanel.BackColor = Color.LightGray;
			navigationPanel.Dock = DockStyle.Left;
			navigationPanel.Width = ClientSize.Width / 4;
			this.Controls.Add(navigationPanel);

			workspacePanel = new Panel();
			workspacePanel.BackColor = Color.White;
			workspacePanel.Dock = DockStyle.Fill;
			this.Controls.Add(workspacePanel);
		}

		private void ResizeButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Работаем!");
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			textBox.Width = ClientSize.Width / 2 - 15;
			resizeButton.Location = new Point(textBox.Width + 20, 10);
			navigationPanel.Width = ClientSize.Width / 4;
		}
	}
}
