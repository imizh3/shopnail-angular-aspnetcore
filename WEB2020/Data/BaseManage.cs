using Microsoft.Extensions.Configuration;
namespace WEB2020.Data
{
    public class BaseManage
    {
        public string DataBaseXnt = "";
        public string Makho = "";
        public string Madonvi = "";
        public string Maptnx = "";
        public bool Checkton = false;

        public string trangThaiHTKT = "1";
        public IConfiguration _configuration;

        public BaseManage(IConfiguration configuration)
        {
            _configuration = configuration;
            this.DataBaseXnt = _configuration.GetValue<string>("Dataxnt");
            this.Makho = _configuration.GetValue<string>("Makhoban");
            this.Madonvi = _configuration.GetValue<string>("Madonvi");
            this.Maptnx = _configuration.GetValue<string>("Maptnx");
            try
            {
                if (_configuration.GetValue<string>("Checkton") == "10")
                {
                    Checkton = true;
                }
            }
            catch
            {
                Checkton = false;
            }

            DB.Set_Connect(_configuration.GetConnectionString("MartConnection"));

        }
    }
}
