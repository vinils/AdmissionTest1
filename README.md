# AdmissionTest1
Admission test mode on Nov/2016 in 48 hrs

Criar um método em .NET com a seguinte assinatura:

public string ChangeDate(string date, char op, long value);

 

Dado que:

 
date: é uma data em forma de String formatada no padão “dd/MM/yyyy HH24:mi”

op: operação, só poderá aceitar os caracteres ‘+’ e ‘-’

value: valor em minutos que deve ser acrescentado ou decrementado

Regras e Restrições:

 
         Não é permitida a utilização de qualquer classe ou biblioteca não nativa

·         Não é permitida a utilização das classes DateTime e TimeSpan

·         Se o valor for menor que zero, o sinal deve ser ignorado (tratar como positivo)

·         Ignore o fato de fevereiro poder possuir 28 ou 29 dias. Considere-o sempre com 28

·         Ignore a existência de horário de verão

 

Exemplo:

ChangeDate("01/03/2010 23:00", '+', 4000) = "04/03/2010 17:40"

 

Importante: só serão aceitas provas de candidatos que:

 

Anexarem no e-mail apenas um arquivo comprimido no formato ZIP. O nome do arquivo deve ser o nome completo do candidato separado por espaços.
Þ     Ex: Se o candidato se chama João Sebastião Bach, então o nome do arquivo deverá ser João Sebastião Bach.zip

Enviarem dentro do zip apenas arquivos da linguagem C#, isto é, com extensão *.cs. Mais de um arquivo *.cs pode ser enviado.
Não serão aceitos arquivos de outras extensões e formatos, pois não são necessários (ex: dll, xml, html, js, sln, csproj, csproj.user, etc)
Colocarem todas as classes da solução dentro de um namespace que seja o nome completo do candidato sem espaços.
Þ     Ex: Se o candidato se chama João Sebastião Bach, então o namespace do código deverá ser JoãoSebastiãoBach
