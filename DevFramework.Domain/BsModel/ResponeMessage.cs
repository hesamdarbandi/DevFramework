using System;
namespace DevFramework.Domain.BsModel
{
    public class ResponeMessage<T> where T : class
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResponeMessage(int code, string message, T data = null)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }
    }
}
