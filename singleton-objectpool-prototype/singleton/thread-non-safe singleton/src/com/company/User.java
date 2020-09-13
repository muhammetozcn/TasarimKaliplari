package com.company;

import java.util.Scanner;

public class User {
    private String kullaniciAdi;
    private String sifre;

    public static User kullaniciOlustur(){
        User user=new User();
        Scanner scanner=new Scanner(System.in);
        System.out.println("Kullanıcı adınızı giriniz:");
        user.kullaniciAdi=scanner.next();
        System.out.println("Kullanıcı sifrenizi giriniz:");
        user.sifre=scanner.next();
        return user;
    }

    public String getKullaniciAdi() {
        return kullaniciAdi;
    }

    public String getSifre() {
        return sifre;
    }
}
