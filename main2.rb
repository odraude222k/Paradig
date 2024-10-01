class Carro:
  attr_accessor :marca, :modelo, :ano, :cor

  def initialize(marca, modelo, ano, cor):
      @marca = marca
      @modelo = modelo
      @ano = ano
      @cor = cor
  end

  def Descrever:
    puts "Marca: #{@marca}, Modelo: #{@modelo}, Ano: #{@ano}"
  end

end

class CarroEsportivo < Carro:
  attr_accessor :marca, :modelo, :ano, :cor

  def Descrever:
    puts "Carro esportivo"
    super
  end

end

class CarroSedan<Carro:
  attr_acessor:marca,:modelo,:ano,:cor
  def Descrever:
    puts "Carro sedan"
    super
  end
end
fusca = Carro.new("Volkswagen", "Fusca", 1978, "Azul")
ferrari = CarroEsportivo.new("Ferrari", "458", 1987) "Vermelho")
prisma = CarroSedan.new("Nissan", "Prisma", 1990)

fusca.descrever
ferrari.descrever
prisma.descrever
  
  