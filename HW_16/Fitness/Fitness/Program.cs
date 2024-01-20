namespace Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          List<Client> clients = new List<Client>();

            for (int i = 0; i < 120; i++)
            {
                clients.Add(new Client(i));                
            }

            //var test = clients.Select(p => p.Year).SelectMany(y => y.Values).ToList();
            var test = (from p in clients
                        from y in p.Year
                        from m in y.Value
                        group m by y.Key); //группируем по годам 
                        
            
                       
        }
    }
}
