import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

//package 8016-Java;

public class Exemplo4_input {
    public static void main(String[] args) throws IOException {
        InputStreamReader inputStreamReader = new InputStreamReader(System.in);
        BufferedReader reader = new BufferedReader(inputStreamReader);
        System.out.println("Indique primeiro valor: ");
        int valor = Integer.parseInt(reader.readLine());
        System.out.println(valor + 1);
    }
}
