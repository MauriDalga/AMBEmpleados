namespace AMBEmpleados.Controllers
{
    using DataAccess;
    public class AMBController
    {
        private AMBController instance;
        private IRepository dataSource;
        private AMBController(IRepository _dataSource)
        {
            dataSource = _dataSource;
        }

        public static AMBController Instance()
        {
            if(Instance == null)
            {
                Instance = new AMBController
            }
        }
    }
}
