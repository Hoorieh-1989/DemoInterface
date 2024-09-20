namespace DemoInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button ButtonSave;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            ButtonSave = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(83, 154);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Save to File";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(textBox1);
            Controls.Add(ButtonSave);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
