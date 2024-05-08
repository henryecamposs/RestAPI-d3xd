using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using wresapi_d3xd.Entities;

namespace wResAPI_d3xd
{
    public static class JSONParser
    {
        //   public ArrayList<inven_table> parseDepartment(JObject Objeto)
        //{
        //      ArrayList<DeptTable> arrayList=new ArrayList<DeptTable>();
        //      try {
        //            JSONArray jsonArray=object.getJSONArray("Value");
        //            JSONObject jsonObj=null;
        //            for(int i=0;i<jsonArray.length();i++)
        //            {
        //                  jsonObj=jsonArray.getJSONObject(i);
        //                  arrayList.add(new DeptTable(jsonObj.getInt("no"), jsonObj.getstring("name")));
        //            }

        //      } catch (JSONException e) {
        //            // TODO Auto-generated catch block
        //            Log.d("JSONParser => parseDepartment", e.getMessage());
        //      }
        //      return arrayList;
        //}
        public static inven_verificador parserInvenTable(JObject Jobject)
        {
            inven_verificador result = null;
            try
            {
                if (Jobject["Value"] is JArray jsonArray)
                {
                    result = clsUtilClass.RellenarJTokenToClass(jsonArray[0], new inven_verificador());
                    foreach (JToken row in jsonArray)
                    {
                        result.barra = (string)row["barra"];
                        result.codigo = (string)row["codigo"];
                        result.descr = (string)row["descr"];
                        result.precio = (double)row["precio"];
                        result.precio1 = (double)row["precio1"];
                        result.tiva = (int)row["tiva"];
                    }
                }
                else if(Jobject["Value"] is JObject jsonObject)
                {
                    result = clsUtilClass.RellenarJTokenToClass(jsonObject, new inven_verificador());
                    //result.barra = (string)row["barra"];
                    //result.codigo = (string)row["codigo"];
                    //result.descr = (string)row["descr"];
                    ////result.DESDE_O =  row["desde_o"];
                    ////result.HASTA_O = (string)row["hasta_o"];
                    //result.pidecanti = (int)row["pidecanti"];
                    //result.pidepre = (int)row["pidepre"];
                    //result.precio = (double)row["precio"];
                    //result.precio1 = (double)row["precio1"];
                    //result.precio1_e = (double)row["precio1_e"];
                    //result.precio1_o = (double)row["precio1_o"];
                    //result.tiva = (int)row["tiva"];
                }
            }
            catch (JsonException e)
            {
                // TODO Auto-generated catch block
                //Log.Debug("JSONParser => parseUserDetails", e.Message);
            }
            return result;
        }

    }
}
