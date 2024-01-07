using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDTO<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }


        public static CustomResponseDTO<T> Success(int statuscode, T data)
        {
            return new CustomResponseDTO<T> { StatusCode = statuscode, Data = data};
        }

        public static CustomResponseDTO<T> Success(int statuscode)
        {
            return new CustomResponseDTO<T> { StatusCode = statuscode};
        }

        public static CustomResponseDTO<T> Fail(int statuscode,List<string> errors)
        {
            return new CustomResponseDTO<T> { StatusCode = statuscode ,Errors=errors};
        }

        public static CustomResponseDTO<T> Fail(int statuscode,string error)
        {
            return new CustomResponseDTO<T> { StatusCode = statuscode, Errors = new List<string> {error } };
        }
    }
}