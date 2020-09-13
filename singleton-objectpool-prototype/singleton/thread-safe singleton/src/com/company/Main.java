package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here
        DBA dba=DBA.getInstance();
        int kullaniciSayisi=0;
        Runner runner = new Runner("Thread 0");
        Runner runner2 = new Runner("Thread 1");
        Runner runner3 = new Runner("Thread 2");
        runner.start();
        runner3.start();
        runner2.start();
        }


    }

