﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ResponseDtos
{
    public class BaseResponseDto<T> where T : IComparable<T>
    {
        public BaseResponseDto(int id) {
        
        
        }
    }
}
