using System.Collections.Generic;
using System.Linq;
using TaskList.IoC;
using TaskList.Model.Model;

namespace TaskList.ViewModel {
    public class CabinetViewModel : BaseViewModel {

        public Employee CurrenEmployee => Constants.CurrentEmployee;
        public Permissions Permissions => Constants.CurrentEmployee.Permissions;
        public List<Employee> Employees => Permissions.CanAddEmployee || Permissions.CanEditEmployee || 
                                           Permissions.CanRemoveEmployee ? Constants.Db.Employees.ToList() : null;
        public CabinetViewModel() {
            Constants.Main.Title = $"Кабинет ({Constants.CurrentEmployee.Fio})";
        }
    }
}