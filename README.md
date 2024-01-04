# Fuentes consultadas:
https://stackoverflow.com/questions/390491/how-to-add-item-to-the-beginning-of-listt

# Codigo generado por ChatGPT:
Ejemplo para agregar 1 a cada elemento de la lista usando Select:
```
List<int> numerosMasUno = numeros.Select(numero => numero + 1).ToList();
```

Y algunos refactors menores para remover casteos.

# Notas
Hecho originalmente en .NET 8.
