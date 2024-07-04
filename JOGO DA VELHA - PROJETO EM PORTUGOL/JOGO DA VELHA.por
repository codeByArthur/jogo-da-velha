programa
{
	cadeia p1 = "", p2 = "", p3 = "", p4 = "", p5 = "", p6 = "", p7 = "", p8 = "", p9 = ""
	
	funcao jogo()
	{
		escreva("\n=====================================")
		escreva("\n|     JOGO DA VELHA SUPER LEGAL     |")
		escreva("\n=====================================")

		escreva("\n\n")

		
		escreva("             1    2    3 ", 
			   "\n",
			   "\n       1   ", p1, p2, p3,
			   "\n", 
		  	   "\n       2   ", p4, p5, p6, 
		  	   "\n", 
		        "\n       3   ", p7, p8, p9)
		
		escreva("\n\n")
	}
		
	funcao inicio()
	{	
		cadeia vitoria = "", derrota = ""
		logico empate = verdadeiro
		
		faca
		{
			cadeia v[3][3] = {{"  -  ", "  -  ", "  -  "}, 
						   	    {"  -  ", "  -  ", "  -  "},
					              {"  -  ", "  -  ", "  -  "}}

			logico fimpartida = falso
			inteiro jogada = 1, c, l
			
			
			p1 = v[0][0] p2 = v[0][1] p3 = v[0][2]
			p4 = v[1][0] p5 = v[1][1] p6 = v[1][2] 
			p7 = v[2][0] p8 = v[2][1] p9 = v[2][2]
			
			faca
			{
				jogo()
				escreva("\n")
				
				se(jogada % 2 == 1)
				{
					escreva("Jogada ", jogada, ", vez do jogador 1")
					escreva("\n\n")
	
					faca
					{
						escreva("LINHA: ")
						leia(l)
						escreva("COLUNA: ")
						leia(c)
						
						limpa()

						jogo()
						
						escreva("Jogada ", jogada, ", vez do jogador 2")
						escreva("\n\n")
				
					}enquanto(v[l-1][c-1] == "  X  " ou v[l-1][c-1] == "  O  ")
					
	
					v[l-1][c-1] = "  X  "
	
					se(v[0][0] == "  X  " e v[0][1] == "  X  " e v[0][2] == "  X  ")
					{
						vitoria = "JOGADOR 1"
						derrota = "JOGADOR 2"
						fimpartida = verdadeiro	
						empate = falso	
					} 
					senao
						se(v[1][0] == "  X  " e v[1][1] == "  X  " e v[1][2] == "  X  ")
						{
							vitoria = "JOGADOR 1"
							derrota = "JOGADOR 2"
							fimpartida = verdadeiro
							empate = falso	
						}
						senao
							se(v[2][0] == "  X  " e v[2][1] == "  X  " e v[2][2] == "  X  ")
							{
								vitoria = "JOGADOR 1"
								derrota = "JOGADOR 2"
								fimpartida = verdadeiro
								empate = falso					
							}
							senao
								se(v[0][0] == "  X  " e v[1][0] == "  X  " e v[2][0] == "  X  ")
								{
									vitoria = "JOGADOR 1"
									derrota = "JOGADOR 2"
									fimpartida = verdadeiro	
									empate = falso				
								}
								senao
									se(v[0][1] == "  X  " e v[1][1] == "  X  " e v[2][1] == "  X  ")
									{
										vitoria = "JOGADOR 1"
										derrota = "JOGADOR 2"
										fimpartida = verdadeiro		
										empate = falso			
									}
									senao
										se(v[0][2] == "  X  " e v[1][2] == "  X  " e v[2][2] == "  X  ")
										{
											vitoria = "JOGADOR 1"
											derrota = "JOGADOR 2"
											fimpartida = verdadeiro	
											empate = falso				
										}
										senao
											se(v[0][0] == "  X  " e v[1][1] == "  X  " e v[2][2] == "  X  ")
											{
												vitoria = "JOGADOR 1"
												derrota = "JOGADOR 2"
												fimpartida = verdadeiro	
												empate = falso				
											}
											senao
												se(v[0][2] == "  X  " e v[1][1] == "  X  " e v[2][0] == "  X  ")
												{
													vitoria = "JOGADOR 1"
													derrota = "JOGADOR 2"
													fimpartida = verdadeiro	
													empate = falso				
												}
												senao
													se(jogada == 9 e fimpartida == falso)
													{
														fimpartida = verdadeiro
													}
				}
				senao
				{
					escreva("Jogada ", jogada, ", vez do jogador 2")
					escreva("\n\n")
	
					faca
					{
						escreva("LINHA: ")
						leia(l)
						escreva("COLUNA: ")
						leia(c)

						limpa()

						jogo()
						
						escreva("Jogada ", jogada, ", vez do jogador 2")
						escreva("\n\n")
						
					}enquanto(v[l-1][c-1] == "  O  " ou v[l-1][c-1] == "  X  ")
	
					v[l-1][c-1] = "  O  "
	
					se(v[0][0] == "  O  " e v[0][1] == "  O  " e v[0][2] == "  O  ")
					{
						vitoria = "JOGADOR 2"
						derrota = "JOGADOR 1"
						fimpartida = verdadeiro		
						empate = falso	
					} 
					senao
						se(v[1][0] == "  O  " e v[1][1] == "  O  " e v[1][2] == "  O  ")
						{
							vitoria = "JOGADOR 2"
							derrota = "JOGADOR 1"
							fimpartida = verdadeiro
							empate = falso	
						}
						senao
							se(v[2][0] == "  O  " e v[2][1] == "  O  " e v[2][2] == "  O  ")
							{
								vitoria = "JOGADOR 2"
								derrota = "JOGADOR 1"
								fimpartida = verdadeiro
								empate = falso					
							}
							senao
								se(v[0][0] == "  O  " e v[1][0] == "  O  " e v[2][0] == "  O  ")
								{
									vitoria = "JOGADOR 2"
									derrota = "JOGADOR 1"
									fimpartida = verdadeiro		
									empate = falso			
								}
								senao
									se(v[0][1] == "  O  " e v[1][1] == "  O  " e v[2][1] == "  O  ")
									{
										vitoria = "JOGADOR 2"
										derrota = "JOGADOR 1"
										fimpartida = verdadeiro	
										empate = falso				
									}
									senao
										se(v[0][2] == "  O  " e v[1][2] == "  O  " e v[2][2] == "  O  ")
										{
											vitoria = "JOGADOR 2"
											derrota = "JOGADOR 1"
											fimpartida = verdadeiro	
											empate = falso				
										}
										senao
											se(v[0][0] == "  O  " e v[1][1] == "  O  " e v[2][2] == "  O  ")
											{
												vitoria = "JOGADOR 2"
												derrota = "JOGADOR 1"
												fimpartida = verdadeiro
												empate = falso					
											}
											senao
												se(v[0][2] == "  O  " e v[1][1] == "  O  " e v[2][0] == "  O  ")
												{
													vitoria = "JOGADOR 2"
													derrota = "JOGADOR 1"
													fimpartida = verdadeiro	
													empate = falso				
												}
				}
	
				p1 = v[0][0] p2 = v[0][1] p3 = v[0][2]
				p4 = v[1][0] p5 = v[1][1] p6 = v[1][2] 
				p7 = v[2][0] p8 = v[2][1] p9 = v[2][2]
	
				jogada++
	
				limpa()
		
			}enquanto(fimpartida == falso)
	
			
		}enquanto(empate == verdadeiro)

		jogo()
	
			escreva("\n=====================================")
			escreva("\n|             RESULTADO             |")
			escreva("\n=====================================")
			escreva("\n| VENCEDOR: ", vitoria, "               |")
			escreva("\n| PERDEDOR: ", derrota, "               |")
			escreva("\n=====================================")
	
			escreva("\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1555; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */