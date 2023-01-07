#bot telegram

#importando biblioteca do Bot:
import telebot

#passando o token do bot para o cod:
token = "5875606200:AAGiD8vSHfb78SylqPNK-xyzHOttdJmIdKw"
bot = telebot.TeleBot(token)

@bot
def bot_main(mensagem):
    bot.reply_to(mensagem, "Teste de funcionalidade do grupo!")
    bot.reply_to(mensagem, "esse é o unico comando ativo, não tente mais comandos!")

    #bot.send_message(1656176975, mensagem)
    print(mensagem)

bot.infinity_polling()
