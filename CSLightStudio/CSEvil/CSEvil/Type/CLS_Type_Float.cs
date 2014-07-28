﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSEvil
{
    class CLS_Type_Float : ICLS_Type
    {
        public CLS_Type_Float()
        {
            function = new RegHelper_TypeFunction(typeof(float));
        }
        public string keyword
        {
            get { return "float"; }
        }

        public Type type
        {
            get { return typeof(float); }
        }

        public ICLS_Value MakeValue(object value)
        {
            CLS_Value_Value<float> v = new CLS_Value_Value<float>();
            v.value_value = (float)value;
            
            return v;

        }

        public object ConvertTo(ICLS_Environment env, object src, Type targetType)
        {
            if (targetType == typeof(int))
            {
                return (int)(float)src;
            }
            else if (targetType == typeof(uint))
            {
                return (uint)(float)src;
            }
            else if (targetType == typeof(double))
            {
                return (double)(float)src;
            }
            else if (targetType == typeof(float))
            {
                return (float)src;
            }
            throw new NotImplementedException();
        }

        public object Math2Value(ICLS_Environment env, char code, object left, CLS_Content.Value right, out Type returntype)
        {
            returntype = typeof(float);
            if (right.type == typeof(int))
            {
                if (code == '+')
                    return (float)left + (float)(int)right.value;
                else if (code == '-')
                    return (float)left - (float)(int)right.value;
                else if (code == '*')
                    return (float)left * (float)(int)right.value;
                else if (code == '/')
                    return (float)left / (float)(int)right.value;
                else if (code == '%')
                    return (float)left % (float)(int)right.value;
            }
            else if (right.type == typeof(uint))
            {
                if (code == '+')
                    return (float)left + (float)(uint)right.value;
                else if (code == '-')
                    return (float)left - (float)(uint)right.value;
                else if (code == '*')
                    return (float)left * (float)(uint)right.value;
                else if (code == '/')
                    return (float)left / (float)(uint)right.value;
                else if (code == '%')
                    return (float)left % (float)(uint)right.value;
            }
            else if (right.type == typeof(double))
            {
                returntype = typeof(double);

                if (code == '+')
                    return (double)(float)left + (double)right.value;
                else if (code == '-')
                    return (double)(float)left - (double)right.value;
                else if (code == '*')
                    return (double)(float)left * (double)right.value;
                else if (code == '/')
                    return (double)(float)left / (double)right.value;
                else if (code == '%')
                    return (double)(float)left % (double)right.value;
            }
            else if (right.type == typeof(float))
            {
                returntype = typeof(float);
                if (code == '+')
                    return (float)left + (float)right.value;
                else if (code == '-')
                    return (float)left - (float)right.value;
                else if (code == '*')
                    return (float)left * (float)right.value;
                else if (code == '/')
                    return (float)left / (float)right.value;
                else if (code == '%')
                    return (float)left % (float)right.value;
            }
            throw new NotImplementedException();
        }

        public bool MathLogic(ICLS_Environment env, logictoken code, object left, CLS_Content.Value right)
        {
            if (right.type == typeof(int))
            {
                if (code == logictoken.equal)
                    return (float)left == (int)right.value;
                else if (code == logictoken.less)
                    return (float)left < (int)right.value;
                else if (code == logictoken.less_equal)
                    return (float)left <= (int)right.value;
                else if (code == logictoken.more)
                    return (float)left > (int)right.value;
                else if (code == logictoken.more_equal)
                    return (float)left >= (int)right.value;
                else if (code == logictoken.not_equal)
                    return (float)left != (int)right.value;
            }
            else if (right.type == typeof(uint))
            {
                if (code == logictoken.equal)
                    return (float)left == (uint)right.value;
                else if (code == logictoken.less)
                    return (float)left < (uint)right.value;
                else if (code == logictoken.less_equal)
                    return (float)left <= (uint)right.value;
                else if (code == logictoken.more)
                    return (float)left > (uint)right.value;
                else if (code == logictoken.more_equal)
                    return (float)left >= (uint)right.value;
                else if (code == logictoken.not_equal)
                    return (float)left != (uint)right.value;
            }
            else if (right.type == typeof(double))
            {
                if (code == logictoken.equal)
                    return (float)left == (double)right.value;
                else if (code == logictoken.less)
                    return (float)left < (double)right.value;
                else if (code == logictoken.less_equal)
                    return (float)left <= (double)right.value;
                else if (code == logictoken.more)
                    return (float)left > (double)right.value;
                else if (code == logictoken.more_equal)
                    return (float)left >= (double)right.value;
                else if (code == logictoken.not_equal)
                    return (float)left != (double)right.value;
            }
            else if (right.type == typeof(float))
            {
                if (code == logictoken.equal)
                    return (float)left == (float)right.value;
                else if (code == logictoken.less)
                    return (float)left < (float)right.value;
                else if (code == logictoken.less_equal)
                    return (float)left <= (float)right.value;
                else if (code == logictoken.more)
                    return (float)left > (float)right.value;
                else if (code == logictoken.more_equal)
                    return (float)left >= (float)right.value;
                else if (code == logictoken.not_equal)
                    return (float)left != (float)right.value;
            }
            throw new NotImplementedException();
        }

        public ICLS_TypeFunction function
        {
            get;
            private set;
        }
        public object DefValue
        {
            get { return (float)0; }
        }
    }
}
