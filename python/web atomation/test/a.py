from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.common.by import By
from pytesseract import pytesseract 
from time import sleep
chrome_options = webdriver.ChromeOptions()




driver = webdriver.Chrome(service=Service(ChromeDriverManager().install()),options=chrome_options)

driver.get("https://www.bbva.pe/personas/olvido-contrasena.html")
sleep(16)
driver.find_element(By.XPATH, "/html/body/div/div/div/div/div/div/form/article/div[2]/div/div[1]/div/div[1]/div/div[1]/div/div/input").send_keys("gay")
sleep(4)
