package com.company;

import java.sql.*;

public class DBA {
    private static DBA instance;
    private Connection conn = null;
    private Statement stmt;
    private ResultSet results = null;
    private  String DB_url="jdbc:mysql://localhost:3306/userdb?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
    private  String DB_user="root";
    private  String DB_password="";
    private  String driver = "com.mysql.cj.jdbc.Driver";



    private DBA(){
        try{
            Class.forName(driver).newInstance();
            conn=DriverManager.getConnection(DB_url,DB_user,DB_password);
            stmt=(Statement) conn.createStatement();
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    public static DBA getInstance(){
            if(instance==null){
                instance=new DBA();
        }
        return instance;
    }
    public void closeConnection() throws SQLException {
        stmt.close();
        conn.close();
    }

    private ResultSet DB_query(String sql){
        try{

            results=stmt.executeQuery(sql);

        }catch(Exception e){
            e.printStackTrace();
        }
        return results;
    }
    private ResultSet DB_UPDATE(String sql){
        try{

            stmt.executeUpdate(sql);

        }catch(Exception e){
            e.printStackTrace();
        }
        return results;
    }


    public void userKaydet(User user){
        String sql="INSERT INTO userinfo(kullaniciAdi,sifre) values('"
                +user.getKullaniciAdi()+"','"+user.getSifre()+"')";
        DB_UPDATE(sql);
        System.out.println("kullanici kaydedildi");


    }
    public boolean userBul(User user){
        String sql="SELECT EXISTS(Select * FROM userinfo WHERE kullaniciAdi='"
                +user.getKullaniciAdi()+" ' AND sifre= '"+user.getSifre()+"')";
        ResultSet kullanici=DB_query(sql);
      try {
          while (kullanici.next()){
              String sonuc=kullanici.getString(1);
              System.out.println(sonuc);
              return  sonuc.equals("1")?true:false;

          }
      }catch(Exception e){

      }
        return false;
    }

}
