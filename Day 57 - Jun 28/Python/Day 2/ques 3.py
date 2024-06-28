
players = [
    {"name": "Alice", "score": 10},
    {"name": "Bob", "score": 15},
    {"name": "Charlie", "score": 12},
    {"name": "Diana", "score": 20},
    {"name": "Eve", "score": 18},
    {"name": "Frank", "score": 8},
    {"name": "Grace", "score": 25},
    {"name": "Heidi", "score": 5},
    {"name": "Ivan", "score": 30},
    {"name": "Judy", "score": 22},
    {"name": "Kyle", "score": 17},
    {"name": "Liam", "score": 16},
    {"name": "Mia", "score": 14},
    {"name": "Noah", "score": 9},
    {"name": "Olivia", "score": 23},
    {"name": "Pam", "score": 11},
    {"name": "Quinn", "score": 7},
    {"name": "Ray", "score": 6},
    {"name": "Sophia", "score": 19},
    {"name": "Tyler", "score": 13}
]

sorted_players = sorted(players, key=lambda x: (-x['score'], x['name']))

for player in sorted_players[:10]:
    print(f"Name: {player['name']}, Score: {player['score']}")