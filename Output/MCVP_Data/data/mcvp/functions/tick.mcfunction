execute if score <Global> MCVPPlaying matches ..-1 run scoreboard players set <Global> MCVPPlaying 0
execute if score <Global> MCVPPlaying matches 2.. run scoreboard players set <Global> MCVPPlaying 1
execute if score <Global> MCVPPlaying matches 0 run scoreboard players set <Global> MCVPTimer 0
function mcvp:destroy_frames
function mcvp:create_frames
execute if score <Global> MCVPPlaying matches 1 run scoreboard players add <Global> MCVPTimer 1
execute if score <Global> MCVPTimer matches ..-1 run scoreboard players set <Global> MCVPTimer 0
execute if score <Global> MCVPTimer matches 89.. run function mcvp:stop