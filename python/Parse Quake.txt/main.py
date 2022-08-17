import json
import re



#Res I use
res ={
'init':r'.InitGame:',
'changed':r'ClientUserinfoChanged: (.) n\\(.*)\\t\\',
'kill':r'Kill: (.).*: (.*) killed (.*) by',
'terminou': r'ShutdownGame'
}


                

                    
def dict_game(start,end,id,filename):
    game={'game':id,'status':{'total_kills':0, 'players':[]}}

    with open(filename,encoding='UTF-8',errors='ignore') as f:
        data= f.readlines()[start:end]
        count_kill, killed = kills(data)
        players = players_list(data)
    
    total_kills = 0
    #the total kills of wich game
    for i in count_kill.values():
        total_kills += i
    game['status']['total_kills'] = total_kills
    
    #information of wich player
    for i in players.items():
        names = list(i[1])
        nome = names[0]
        oldnames=[name for name in names if name !=nome] 
        kil_player = 0
        #kills of the player
        for nu in count_kill:
            if i[0] == nu:
                kil_player = count_kill[nu]
                for death in killed:
                    if death in names:
                        kil_player-1
            
            
                
        player = {}
        player['id'] = i[0]
        player['nome'] = nome
        player['kills'] = kil_player
        player['oldnames'] = oldnames
        game['status']['players'].append(player)
    return game
        
    
    
    
        


def players_list(data):
    #id of wich player
    players={}
    for row in data:   
        if re.search(res['changed'],row):
            
            change = re.search(res['changed'],row)
        
            if change.group(1) not in players:
                players[change.group(1)] = {change.group(2)}
            else:
                players[change.group(1)].add(change.group(2))
    return players
                   
def kills(data):
    # hoy many kills wich player have
    count_kill = {}
    # players who were killed for the <world)
    killed = []
    for row in data:

        if re.search(res['kill'],row):
            ki = re.search(res['kill'],row)
            if ki.group(1) not in count_kill:
                count_kill[ki.group(1)] = 1
            else:
                count_kill[ki.group(1)] += 1
            if ki.group(1) == '1':
                killed.append(ki.group(3))
    return (count_kill,killed)
    
                
def main(filename):
    #list of the games
    games = list()
    id = 0
    numend = 0
    numstart = 0
    with open(filename) as f:
        for num,row in enumerate(f):
            if re.search(res['init'],row):
                numstart=num+1
                id+=1
            numend+=1
            if re.search(res['terminou'],row):
                game = dict_game(numstart,numend,id,filename)
                games.append(game)
    
    
    with open('json_data.json', 'w') as outfile:
     json.dump(games, outfile)
                
                
                

main('Quake.txt')
