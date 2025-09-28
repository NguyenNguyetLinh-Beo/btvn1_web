// api.aspx.cs
using System;
using System.Web;
using System.Web.UI;
using QuadraticSolverLib;

public partial class api : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Lấy params từ querystring (GET). Nếu muốn POST, xử lý Request.Form.
        string sa = Request.QueryString["a"];
        string sb = Request.QueryString["b"];
        string sc = Request.QueryString["c"];

        double a = 0.0, b = 0.0, c = 0.0;
        bool okA = Double.TryParse(sa, out a);
        bool okB = Double.TryParse(sb, out b);
        bool okC = Double.TryParse(sc, out c);

        Response.ContentType = "application/json";
        Response.Charset = "utf-8";

        if (!okA || !okB || !okC)
        {
            string badJson = "{\"error\":\"Tham số không hợp lệ, vui lòng gửi a,b,c là số thực.\"}";
            Response.Write(badJson);
            Response.End();
            return;
        }

        QuadraticSolver solver = new QuadraticSolver();
        solver.A = a;
        solver.B = b;
        solver.C = c;
        string ketqua = solver.Solve();

        // Trả JSON đơn giản (manual)
        // escape quotes and newlines
        string escaped = ketqua.Replace("\\", "\\\\").Replace("\r", "\\r").Replace("\n", "\\n").Replace("\"", "\\\"");
        string json = "{\"ketqua\":\"" + escaped + "\"}";

        Response.Write(json);
        Response.End();
    }
}
