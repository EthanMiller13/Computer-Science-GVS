package MyTododList;

public class Main {
    public static void main(String[] args){
        String[] todos = {"wash the dishes", "take a walk"};
        String[] statuses = {"done", "todo"};

        for(int i = 0; i < todos.length; i++){
            String text = String.format("%s\t\t[%s]", todos[i], statuses[i]);
            System.out.println(text);
        }
    }

    public static void add_todo(String todo, String status){
        System.out.println(todos);
    }
}
