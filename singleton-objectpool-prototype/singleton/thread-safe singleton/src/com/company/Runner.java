package com.company;

public class Runner extends Thread {
    String threadname;
        public Runner(String name){
        this.threadname=name;


    }

    @Override
    public void run() {


        for (int i = 0; i < 1000; i++) {
            DBA dba=DBA.getInstance();
            int rnd=(int)(Math.random()*190000);
            String kullaniciAdi="abc"+rnd;
            String sifre="bcdf"+rnd;
            dba.userKaydet(kullaniciAdi,sifre);
            System.out.println("Veritabanina Kaydedildi :"+kullaniciAdi+"ThreadName:"+threadname);

        }
    }


}