using DesignPattern.ChainOfResponsibility.DAL.Context;
using DesignPattern.ChainOfResponsibility.DAL.Entities;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext context = new AppDbContext();

            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limitten Fazla Olduğu için İşlem Gerçekleştirilemedi!";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
