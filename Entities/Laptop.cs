namespace WebApplication1.Entities
{
    public class Laptop : Device
    {
        public string GetModel()
        {
            var isConnected = isConnect();
            if (isConnected)
            {
                return "Macbook";
            }
            return "Unknow";
        }
    }
}
