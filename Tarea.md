## Ejercicio: Sistema de Vehículos

Crea una jerarquía de clases para representar vehículos. Tendrás una clase base llamada Vehiculo y una clase derivada llamada Carro.

### Requisitos:

#### Clase base Vehiculo:
- Propiedades: Modelo, Marca, Año
- Constructor que reciba modelo, marca y año
- Método MostrarInformacion() que imprima el modelo, la marca y el año

#### Clase derivada Carro:
- Constructor que reciba modelo, marca y año
- Usa :base(modelo, marca, año) para llamar al constructor de Vehiculo
- Sobrescribe MostrarInformacion() para incluir el modelo también

#### Main:
- Crea una instancia de Carro y llama a MostrarInformacion()
