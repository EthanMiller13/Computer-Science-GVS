package com.EthanMiller;

class Main{
    public static int toBase(long division, int base){
        StringBuilder rem = new StringBuilder();
        while(division != 0){
            rem.append(division % base);
            division = division / base;
        }
        return Integer.parseInt(rem.reverse().toString());

    }

    public static long digPow(int n, int p) {
        // your code
        String num_s = String.valueOf(n);
        int sum = 0;
        int pow;
        char c;
        for(int i = 0; i<num_s.length(); i++){
            pow = p+i;
            c = num_s.charAt(i);
            sum += (int)c^pow;
        }
        return sum;
    }


    public static void main(String[] args){
        /*int base = toBase(234, 3);
        System.out.print("The number " + 234 + " in base " + 3 + ": " + base);
        System.out.print("sds".endsWith("s"));*/

        long k = digPow(46288, 3);
        System.out.println(k);
    }
}