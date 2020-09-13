package com.company;

import java.sql.*;

public class DBA {
    private static DBA instance;
    private Connection conn = null;
    private Statement stmt;
    private ResultSet results = null;
    private String DB_url = "jdbc:mysql://localhost:3306/userdb?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
    private String DB_user = "root";
    private String DB_password = "";
    private String driver = "com.mysql.cj.jdbc.Driver";

    private DBA() {
        try {
            Class.forName(driver).newInstance();
            conn = DriverManager.getConnection(DB_url, DB_user, DB_password);
            stmt = (Statement) conn.createStatement();
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    public static DBA getInstance() {
        synchronized (DBA.class) {
            if (instance == null) {
                instance = new DBA();
            }
            return instance;
        }

    }



    private ResultSet DB_UPDATE(String sql) {
        try {

            stmt.executeUpdate(sql);

        } catch (Exception e) {
            e.printStackTrace();
        }
        return results;
    }
    public void userKaydet(String kullaniciAdi,String sifre){
        String sql="INSERT INTO userinfo(kullaniciAdi,sifre) values('"
                +kullaniciAdi+"','"+sifre+"')";
        DB_UPDATE(sql);
        System.out.println("kullanici kaydedildi");


    }

}


