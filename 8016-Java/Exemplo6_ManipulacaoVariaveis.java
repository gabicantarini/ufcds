public class Exemplo6_ManipulacaoVariaveis {
    public static void main (String[] args){
        int a;
        a=4;
        a++; // a incrementado em 1
        int b;
        b=3;
        int c;
        c=a+b; //c=8
        System.out.println("c=a+b: "+c);

        int d;
        d=b/a; //d=3 / 5=0
        System.out.println("d=b/a: "+d);

        int e;
        e=b%a; //resto da divisão 3/5 ou seja 3
        System.out.println("e=b%a: "+e);
        e+=10; // e incrementado em 10 -> e = 13
        System.out.println("e+=10: "+e);
        e+=2; // e = 15
        System.out.println("e+=2: "+e);
        e-=2; // e = 13
        System.out.println("e-=2: "+e);
        e--; // e incrementado em 10 -> e = 13
        System.out.println("e--: "+e);

        System.out.println("\n int x=0; x++<10;: Ele verifica e depois incrementa. Conta do 1 ao 10.");
        

        for (int x=0; x++<10;){
            System.out.println(x);
        }

        System.out.println("\n int x=0; ++x<10;: Ele incrementa e depois verifica. COnta do 1 ao 9.");
        for (int x=0; ++x<10;){
            System.out.println(x);
        }

        System.out.println("\n int x=0; ++x<10;: Ele verifica, dá o resultado e depois incrementa. COnta do 0 ao 9.");
        for (int x=0; x<10;x++){
            System.out.println(x);
        }
    }
}
