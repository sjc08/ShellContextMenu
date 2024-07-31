namespace Asjc.ShellContextMenu.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShellContextMenu ctxMnu = new();
            FileInfo[] arrFI = [new FileInfo("Asjc.ShellContextMenu.Test.exe")];
            ctxMnu.ShowContextMenu(arrFI, MousePosition);
        }
    }
}
