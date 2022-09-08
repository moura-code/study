from time import sleep

from selenium.webdriver.common.by import By
from selenium import webdriver
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.chrome.service import Service
import threading
class main(object):

    driver: webdriver

    def __init__(self) -> None:
        options = Options()
        options.add_argument("start-maximized")
        self.driver = webdriver.Chrome(service=Service(ChromeDriverManager().install()), options=options)
    def start(self) -> None:
        self.driver.get("https://casadosdados.com.br/solucao/cnpj/pesquisa-avancada")
        self.driver.implicitly_wait(99)
        sleep(30)
        try:
            self.driver.find_element(By.XPATH,'//*[@id="__layout"]/div/div[2]/section/div[6]/div/div/button[1]').click()
        except:
            sleep(6)
            self.driver.implicitly_wait(99)
            self.driver.find_element(By.XPATH,'/html/body/div[2]/div/div/div[2]/section/div[6]/div/div/button[1]').click()
          
        self.driver.implicitly_wait(12)
    
    def links(self) -> list:
        links=[]
        for i in range(1,21):
            self.driver.implicitly_wait(99)
            try:
                url = self.driver.find_element(By.XPATH,f'/html/body/div[2]/div/div/div[2]/section/div[9]/div[1]/div/div/div/div/div[{i}]/article/div/div/p/a').get_attribute('href')
            except:
                url = self.driver.find_element(By.XPATH,f' /html/body/div[2]/div/div/div[2]/section/div[9]/div[1]/div/div/div/div/div[{i}]/article[2]/div/div/p/a').get_attribute('href')
            links.append(url)
            
            self.driver.implicitly_wait(99)
        return links
    def info(self,link):
        self.driver.implicitly_wait(99)
        self.driver.get(link)
        self.driver.implicitly_wait(99)
        sleep(10)
        datos=[]
        datos.append(self.driver.find_element(By.XPATH,'//*[@id="__layout"]/div/div[2]/section[1]/div/div/div[4]/div[1]/div[1]/div[1]/p[2]').text)

        print(datos)




if __name__ == '__main__':
    bot = main()
    bot.start()
    links = bot.links()
    
    for i in links:
        bot.info(i)
        



        




