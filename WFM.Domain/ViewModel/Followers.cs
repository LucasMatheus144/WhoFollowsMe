namespace WFM.Domain.ViewModel
{
    public class Followers
    {
        public List<Usuarios> users { get; set; }

        public List<Grupos> groups { get; set; }
    }

    public class Grupos
    {
        public string title { get; set; }
        public string context { get; set; }

        public List<Usuarios> users { get; set; }
    }
    public class Usuarios
    {
        public string username { get; set; }

        public string full_name { get; set; }

        public string profile_pic_url { get; set; }
    }    
}
