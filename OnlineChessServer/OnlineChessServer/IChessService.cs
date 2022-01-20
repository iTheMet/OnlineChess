using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OnlineChessServer
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IChessService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IChessService
    {
        [OperationContract]
        void DoWork();
    }
}
