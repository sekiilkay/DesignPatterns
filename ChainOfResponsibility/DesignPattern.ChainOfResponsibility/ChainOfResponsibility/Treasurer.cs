using DesignPattern.ChainOfResponsibility.DAL.Context;
using DesignPattern.ChainOfResponsibility.DAL.Entities;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext context = new AppDbContext();
            
            if (request.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Limitten Fazla Olduğu için İşlem Şube Müdür Yardımcısına Yönlendirildi!";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
