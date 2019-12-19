using System;
namespace DevFramework.Service.Dto
{
    public class ResponeMessage<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Date { get; set; }
    }
}
