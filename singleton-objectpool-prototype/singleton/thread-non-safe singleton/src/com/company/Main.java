package com.company;

import java.sql.SQLException;
import java.util.Scanner;

public class Main {
    public static boolean islemKontrolu(String islem) {
        if (islem.equals("1") || islem.equals("2") || islem.equals("3")) {
            return true;
        }
        System.out.println("Hatalı islem yaptınız.");
        return false;
    }

    public static String kullaniciIslemSecimi() {
        Scanner scanner = new Scanner(System.in);
        String islem;
        while (true) {
            System.out.println("Kullanıcı giriş programı " +
                    "Aşağıdaki seçeneklerden birini seçiniz.\n" +
                    "1-kullanıcı oluştur \n" +
                    "2-giriş yap \n" +
                    "3-çıkış"
            );
            islem = scanner.next();
            if (islemKontrolu(islem)) {
                break;
            }
        }
        return islem;
    }

    public static void main(String[] args) throws SQLException {
        while (true) {

            DBA dbConnect = DBA.getInstance();
            String kullaniciIslem=kullaniciIslemSecimi();
            if (kullaniciIslem.equals("1")) {
                User user = User.kullaniciOlustur();
                dbConnect.userKaydet(user);

            } else if (kullaniciIslem.equals("2")) {
                User user = User.kullaniciOlustur();
                boolean userKontrolu = dbConnect.userBul(user);

                if (userKontrolu) {
                    System.out.println("Giriş yaptınız.");
                    dbConnect.closeConnection();
                    break;
                } else
                    System.out.println("Giriş yapamadınız tekrar deneyin.");

            }else if (kullaniciIslem.equals("3")) {
                dbConnect.closeConnection();
                break;
            }
        }

    }
}
