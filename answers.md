# l
Utiliser les Lts version plutot que la derniere versio d'Unity3D permet d'avoir les correctifs/ évolution de la version utilisé sans changer de version d'unity. Le fait de mettre son projet sur une autre version d'unity peut faire du temps notamment par le fait que certaines fonctionnalité ou autres peuvent devenir obselete d'une version à l'autre

#2
Les " magic folder" d'unity sont :
- le dossier Ressources qui permet de charger des éléments à partir de ce dossier au lieu de créer une instance de celui-ci dans la scene 
- le dossier StreamingAssets qui permet par exemple de charger une vidéo

#3
Je créer la racine du dossier asset avec des dossier en fonction du type, par exemple :
Materials
Prefabs
Scene
Scripts
Textures
Ressources

#4
Pour un projet de grande ampleur , je recommenderais pas exemple d'utiliser le plugin de mirror pour un projet multijoueur car celui ci permet l'implémentation du multijoueur assez rapidement, avec une forte communauté et est maintnanable