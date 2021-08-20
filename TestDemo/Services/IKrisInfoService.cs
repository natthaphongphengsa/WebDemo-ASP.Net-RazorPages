using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDemo.Model;

namespace TestDemo.Interfaces
{
    public interface IKrisInfoService
    {
        List<KrisInfo> GetAllKrisInformation();
        List<KrisInfo> GetEmergencies();
        KrisInfo GetKrisInformation(string id);
    }
}
