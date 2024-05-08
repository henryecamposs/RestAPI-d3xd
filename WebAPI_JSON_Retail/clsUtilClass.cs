using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace wResAPI_d3xd
{
    public static class clsUtilClass
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        /// <summary>
        /// Rellena la Clase entidad con los datos del DataRown Enviado
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="Clase"></param>
        /// <returns></returns>
        public static T RellenarDatarowToClass<T>(DataRow dr, T Clase)
        {
            if (dr != null && Clase != null)
            {
                Type type = Clase.GetType();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    string Campo = "";
                    Campo = property.Name;
                    if (dr.Table.Columns.Contains(Campo))
                    {
                        try
                        {
                            //Buscar valores nulos
                            if (property.PropertyType.FullName.ToLower().Contains("system.datetime"))
                            {
                                DateTime value = dr[Campo] == DBNull.Value ? new DateTime() : Convert.ToDateTime(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.double"))
                            {
                                double value = dr[Campo] == DBNull.Value ? 0 : Convert.ToDouble(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.int32"))
                            {
                                Int32 value = dr[Campo] == DBNull.Value ? 0 : Convert.ToInt32(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.int64"))
                            {
                                Int64 value = dr[Campo] == DBNull.Value ? 0 : Convert.ToInt64(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.boolean"))
                            {
                                bool value = dr[Campo] == DBNull.Value ? false : Convert.ToBoolean(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.string"))
                            {
                                string value = dr[Campo] == DBNull.Value ? "" : Convert.ToString(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                return Clase;

            }
            return Clase;

        }


        /// <summary>
        /// Rellena la Clase entidad con los datos del DataRown Enviado
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="Clase"></param>
        /// <returns></returns>
        public static T RellenarJTokenToClass<T>(JToken dr, T Clase)
        {
            if (dr != null && Clase != null)
            {
                Type type = Clase.GetType();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    string Campo = "";
                    Campo = property.Name.ToLower();
                    if (dr[Campo]!=null)
                    {
                        try
                        {
                            //Buscar valores nulos
                            if (property.PropertyType.FullName.ToLower().Contains("system.datetime"))
                            {
                                DateTime value = dr[Campo] == null ? new DateTime() : DateTime.Parse(dr[Campo].ToString());
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.double"))
                            {
                                double value = dr[Campo] == null ? 0 : GetDouble(dr[Campo].ToString(),0);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.int32"))
                            {
                                Int32 value = dr[Campo] == null ? 0 : Convert.ToInt32(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.int64"))
                            {
                                Int64 value = dr[Campo] == null ? 0 : Convert.ToInt64(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.boolean"))
                            {
                                bool value = dr[Campo] == null ? false : Convert.ToBoolean(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                            if (property.PropertyType.FullName.ToLower().Contains("system.string"))
                            {
                                string value = dr[Campo] == null ? "" : Convert.ToString(dr[Campo]);
                                property.SetValue(Clase, value, null);
                            }
                        }
                        catch (Exception ex )
                        {
                            
                        }
                    }
                }
                return Clase;

            }
            return Clase;

        }
        /// <summary>
        /// Obtiene el valor en formato segun el pais
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double GetDouble(string value, double defaultValue)
        {
            double result;
            string output;

            value = value.Trim();
            // Check if last seperator==groupSeperator
            string groupSep = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            if (value.LastIndexOf(groupSep) + 4 == value.Count())
            {
                bool tryParse = double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out result);
                result = tryParse ? result : defaultValue;
            }
            else
            {
                try
                {
                    // Unify string (no spaces, only . )
                    output = value.Trim().Replace(" ", string.Empty).Replace(",", ".");

                    // Split it on points
                    string[] split = output.Split('.');

                    if (split.Count() > 1)
                    {
                        // Take all parts except last
                        output = string.Join(string.Empty, split.Take(split.Count() - 1).ToArray());

                        // Combine token parts with last part
                        output = string.Format("{0}.{1}", output, split.Last());
                    }
                    // Parse double invariant
                    result = double.Parse(output, System.Globalization.CultureInfo.InvariantCulture);

                }
                catch (Exception)
                {
                    return 0;
                }
            }
            return result;
        }

    }

}
