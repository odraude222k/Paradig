#include <iostream>
#include <string>
using namespace std;

class Pessoa{
    public:
        string nome;
        int idade;
        void info(){
            cout << "o nome da pessoa é: " << nome << endl;
        }
        virtual void imprimirIdade(){
            cout << "Idade da pessoa é: " << idade << endl;
        }
        Pessoa(string nome, int idade){
            this->idade=idade;
            this->nome = nome;
        }

}

class Professor : public Pessoa{
    public:
        Professor(string nome,int idade): Pessoa(nome,idade){}
    
        void imprimirIdade()override{
            cout << "Idade do professor é: " << idade << endl;
        }
        void info() override{
            cout << "O nome do professor é: " << nome << endl;
        }
}

class Aluno : public Pessoa{
    public:
        Aluno (string nome,int idade, int matricula): Pessoa(nome,idade){}
        void info() override{
        cout << "Nome do aluno é" << nome << endl;
        }
        void imprimirIdade()override{
            cout << "Idade do aluno é: " << idade << endl;
        } 

        void imprimirMatricula() {
            cout << "A matrícula do aluno é: " << matricula << endl;
        }
    private:
        int matricula;  
    
}

int main(){
    Professor professor();
    Aluno aluno();
    Pessoa pessoa();

    professor.nome = "joao";
    professor.idade = 45;

    aluno.nome = "ze";
    aluno.idade = 20;
    aluno.matricula = 123;

    pessoa.nome = "maria";
    pessoa.idade = 60;

    aluno.info();
    aluno.imprimirMatricula();

    professor.info();
    professor.imprimirIdade();

    aluno.info();
    aluno.imprimirIdade();
    aluno.imprimirMatricula();

    pessoa.info();
    pessoa.imprimirIdade();

}

