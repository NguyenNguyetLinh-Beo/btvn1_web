using System;
using System.Web;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // ✅ Lấy giá trị a, b, c từ query string
        string aStr = Request["a"];
        string bStr = Request["b"];
        string cStr = Request["c"];

        // ✅ Kiểm tra đầu vào hợp lệ
        if (string.IsNullOrEmpty(aStr) || string.IsNullOrEmpty(bStr) || string.IsNullOrEmpty(cStr))
        {
            Response.ContentType = "application/json";
            Response.Write("{\"ketqua\":\"⚠️ Thiếu tham số a, b hoặc c.\"}");
            Response.End();
            return;
        }

        double a, b, c;

        if (!double.TryParse(aStr, out a) || !double.TryParse(bStr, out b) || !double.TryParse(cStr, out c))
        {
            Response.ContentType = "application/json";
            Response.Write("{\"ketqua\":\"⚠️ Tham số không hợp lệ. Vui lòng nhập số.\"}");
            Response.End();
            return;
        }

        // ✅ Tính toán nghiệm phương trình
        string ketqua;
        if (a == 0)
        {
            if (b == 0)
                ketqua = (c == 0) ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
            else
                ketqua = string.Format("Phương trình bậc nhất có nghiệm: x = {-c / b}");
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
                ketqua = "Phương trình vô nghiệm.";
            else if (delta == 0)
                ketqua =string.Format ("Phương trình có nghiệm kép: x = {-b / (2 * a)}");
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ketqua = string.Format("Phương trình có 2 nghiệm: x1 = {0}, x2 = {1}", x1, x2);
            }
        }

        // ✅ Trả kết quả JSON về trình duyệt
        Response.ContentType = "application/json";
        Response.Write("{\"ketqua\":\"" + ketqua.Replace("\"", "\\\"") + "\"}");
        Response.End();
    }
}