namespace dict;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        cmbLang.SelectedIndex = 0;
        FillSampleData();
    }

    // Жишээ өгөгдөл: зөвхөн ажиллаж байх үед харагдана
    void FillSampleData()
    {


        int idx = gridSaved.Rows.Add("Хоосон");
        gridSaved.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(120, 120, 120);
        gridSaved.Rows[idx].DefaultCellStyle.SelectionForeColor = Color.FromArgb(120, 120, 120);
        gridSaved.ClearSelection();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {

    }
}