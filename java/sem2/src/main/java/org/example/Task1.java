// {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}

package org.example;

import org.json.JSONObject;

public class Task1 {

    private static String getWhereStatementByJson(String json){
        JSONObject jsonObject = new JSONObject(json);
        StringBuilder result = new StringBuilder();
        jsonObject.keySet().forEach(key -> {
            String value = (String)jsonObject.get(key);
            if (!value.equals("null")) {
                result.append(key).append(" = '").append(value).append("' and ");
            }
        });
        return result.substring(0,result.length()-5);
    }

    public static void main(String[] args) {
        System.out.println(getWhereStatementByJson("{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}"));
    }
}