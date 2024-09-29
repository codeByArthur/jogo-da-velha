import os

# Função que exibe o jogo
def jogo(): 
    print("=====================================")
    print("| --------- JOGA DA VELHA --------- |")
    print("=====================================")
    print()
    print("       #  │  1  │  2  │  3  │   ", 
        "\n     ―――――│―――――│―――――│―――――│―",
        "\n       1  │",p1,"│",p2,"│",p3,"│",
        "\n     ―――――│―――――│―――――│―――――│―", 
        "\n       2  │",p4,"│",p5,"│", p6,"│", 
        "\n     ―――――│―――――│―――――│―――――│―", 
        "\n       3  │",p7,"│",p8,"│", p9,"│",
        "\n     ―――――│―――――│―――――│―――――│―")

# Função para o jogador informar os dados novamente 
def jogadorRetry(jog):
    # Limpando terminal
    os.system('cls')
    jogo()
    print("\nJogada:", jogada, f"| Vez do jogador {jog}\n")

# Função para verificar se o jogo empatou ou se houve um vencedor
def resultado():
    if empate == True:
            resultadoEmpate()
    else:
        resultadoVencedor()

# Função para exibir o resultado quando houver um vencedor
def resultadoVencedor():
    jogo()   
    print()    
    print("=====================================")
    print("| ----------- RESULTADO ----------- |")
    print("=====================================")
    print(f"| JOGADOR 1: {vencedor} | VITÓRIAS: {vitsJogador1} |")
    print(f"| JOGADOR 2: {perdedor} | VITÓRIAS: {vitsJogador2} |")
    print("=====================================")

# Função para exibir o resultado de empate
def resultadoEmpate():
    jogo()   
    print()    
    print("=====================================")
    print("| ----------- RESULTADO ----------- |")
    print("=====================================")
    print("|             DEU VELHA             |")
    print("=====================================")

# O programa começa a partir daqui
resposta = "s"
vitsJogador1 = 0
vitsJogador2 = 0

# Laço de repetição que controla se os jogadores querem ou não continuar jogando
while resposta == "s" or resposta == "S":
    # Limpando terminal
    os.system('cls')
    vencedor = "" 
    perdedor = ""
    fimpartida = False
    empate = False   
    jogada = 1
    c = 0
    l = 0
    matriz = [
        ["   ", "   ", "   "],
        ["   ", "   ", "   "],
        ["   ", "   ", "   "]
    ]
    p1 = matriz[0][0] 
    p2 = matriz[0][1] 
    p3 = matriz[0][2]
    p4 = matriz[1][0] 
    p5 = matriz[1][1] 
    p6 = matriz[1][2] 
    p7 = matriz[2][0] 
    p8 = matriz[2][1] 
    p9 = matriz[2][2]

    # Laço de repetição para controle do jogo 
    while fimpartida == False:
        jogo()

        # Verificando se é a vez do jogador 1
        if jogada % 2 == 1:
            print("\nJogada:", jogada, "| Vez do jogador 1\n")

            # Laço para controlar o input do jogador
            while True:
                # try/execpt para caso o jogador pressionar Enter sem informar nenhum valor
                try:
                    l = int(input("LINHA: "))
                except:
                    jogadorRetry("1")
                    continue
                # try/execpt para caso o jogador pressionar Enter sem informar nenhum valor
                try:
                    c = int(input("COLUNA: "))
                except: 
                    jogadorRetry("1")
                    continue
                l = l - 1
                c = c - 1
                # Verificando se o input do jogador é válido e se está dentro das limitações da matriz
                if l < 0 or l > 2 or c < 0 or c > 2:
                    jogadorRetry("1")
                    continue
                if matriz[l][c] == " X ":
                    jogadorRetry("1")
                    continue
                elif matriz[l][c] == " O ":
                    jogadorRetry("1")
                    continue
                else:            
                    break

            matriz[l][c] = " X "
            # Verificando se a jogada atual levou o jogador 1 à vitória
            if jogada >= 5:
                if matriz[0][0] == " X " and matriz[0][1] == " X " and matriz[0][2] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	 
                elif matriz[1][0] == " X " and matriz[1][1] == " X " and matriz[1][2] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	 
                elif matriz[2][0] == " X " and matriz[2][1] == " X " and matriz[2][2] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	 
                elif matriz[0][0] == " X " and matriz[1][0] == " X " and matriz[2][0] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	
                elif matriz[0][1] == " X " and matriz[1][1] == " X " and matriz[2][1] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	 
                elif matriz[0][2] == " X " and matriz[1][2] == " X " and matriz[2][2] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	 
                elif matriz[0][0] == " X " and matriz[1][1] == " X " and matriz[2][2] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1	
                elif matriz[0][2] == " X " and matriz[1][1] == " X " and matriz[2][0] == " X ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True	
                    vitsJogador1 += 1
                # Se interpretador chegar nesse último else significa que o jogo empatou
                else:
                    if jogada == 9 and fimpartida == False:
                        fimpartida = True
                        empate = True

        # Vez do jogador 2 caso o if relacionado retorne False                
        else:
            print("\nJogada:", jogada, "| Vez do jogador 2\n")

            while True:
                # try/execpt para caso o jogador pressionar Enter sem informar nenhum valor
                try:
                    l = int(input("LINHA: "))
                except:
                    jogadorRetry("2")
                    continue
                # try/execpt para caso o jogador pressionar Enter sem informar nenhum valor
                try:
                    c = int(input("COLUNA: "))
                except: 
                    jogadorRetry("2")
                    continue
                l = l - 1
                c = c - 1
                # Verificando se o input do jogador é válido e se está dentro das limitações da matriz
                if l < 0 or l > 2 or c < 0 or c > 2:
                    jogadorRetry("2")
                    continue
                if matriz[l][c] == " X ":
                    jogadorRetry("2")
                    continue
                elif matriz[l][c] == " O ":
                    jogadorRetry("2")
                    continue
                else:            
                    break

            matriz[l][c] = " O "
            # Verificando se a jogada atual levou o jogador 2 à vitória
            if jogada >= 6:
                if matriz[0][0] == " O " and matriz[0][1] == " O " and matriz[0][2] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	 
                elif matriz[1][0] == " O " and matriz[1][1] == " O " and matriz[1][2] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	 
                elif matriz[2][0] == " O " and matriz[2][1] == " O " and matriz[2][2] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	 
                elif matriz[0][0] == " O " and matriz[1][0] == " O " and matriz[2][0] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	
                elif matriz[0][1] == " O " and matriz[1][1] == " O " and matriz[2][1] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	 
                elif matriz[0][2] == " O " and matriz[1][2] == " O " and matriz[2][2] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	 
                elif matriz[0][0] == " O " and matriz[1][1] == " O " and matriz[2][2] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	
                elif matriz[0][2] == " O " and matriz[1][1] == " O " and matriz[2][0] == " O ":
                    vencedor = "VENCEDOR"
                    perdedor = "PERDEDOR"
                    fimpartida = True
                    vitsJogador2 += 1	
        
        p1 = matriz[0][0] 
        p2 = matriz[0][1] 
        p3 = matriz[0][2]			
        p4 = matriz[1][0] 
        p5 = matriz[1][1] 
        p6 = matriz[1][2] 
        p7 = matriz[2][0] 
        p8 = matriz[2][1] 
        p9 = matriz[2][2]

        jogada = jogada + 1
        
        # Limpando terminal
        os.system('cls')

    # Exibindo o resultado final 
    resultado()

    # Laço de repetição para controlar o input do jogador
    while True:
        resposta = input("\nDesejam continuar jogando? [S/N]: ")
        # Verificando se o input do jogador é válido 
        if resposta != "s" and resposta != "S" and resposta != "n" and resposta != "N":
            os.system('cls')
            resultado()
            continue
        else:
            break
    
    print()
    # Verificando quem foi o jogador campeão ou se o jogo ficou empatado, para encerrar o programa
    if resposta == "n" or resposta == "N":
        if vitsJogador1 > vitsJogador2:
            print("=====================================")
            print("| ------- JOGADOR 1 CAMPEÃO  ------- |")
        elif vitsJogador1 == vitsJogador2:
            print("=====================================")
            print("| --- O JOGO TERMINOU EMPATADO! --- |")
        else:
            print("=====================================")
            print("| ------- JOGADOR 2 CAMPEÃO ------- |")
        print("=====================================")
        print("| Encerrando o programa ...         |")
        print("=====================================")
        print()