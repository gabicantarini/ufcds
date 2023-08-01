import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Somador {
        public static void main(String[] args) throws IOException {
        InputStreamReader inputStreamReader = new InputStreamReader(System.in);
        BufferedReader reader = new BufferedReader(inputStreamReader);
        System.out.println("Indique primeiro valor: ");
        int valor = Integer.parseInt(reader.readLine());
        System.out.println("Indique o segundo valor: ");
        int valor2 = Integer.parseInt(reader.readLine());
        System.out.println("A soma é: ");
        System.out.println(valor + valor2);
    }
}

