# Some basics Atlas comands:

You have to install MongoDB Shell

## Install Atlas CLI
brew install mongodb-atlas

## Open atlas on the internet browser
atlas setup
This command also will return a verify code 

## Login in atlas by CLI
atlas auth login

## Create a mongoDB Atlas Cluster:
atlas setup --clusterName myAtlasClusterEDU --provider AWS --currentIp --skipSampleData --username myAtlasDBUser --password myatlas-001 | tee atlas_cluster_details.txt

## Create a test cluster
atlas cluster create Test --provider AWS --region US_EAST_1 --members 5 --tier M30 --mdbVersion 5.0 --backup

## Activate ou pause a cluster
atlas clusters pause Cluster_name
atlas clusters start Cluster_name

## Load sample data into Atlas cluster
atlas clusters sampleData load myAtlasClusterEDU

## creating API Keys for a project
atlas projects apiKeys create --role GROUP_OWNER --desc "nEW api KEY"

"desc" means description, 
Copy the key in the terminal cause they won't be accessable in other places

## Create new profile
atlas config profile --profile profile_name

## Override the default profile
atlas clusters init

than would not be necessary type --profile in every command 

## List clusters in JSON format
atlas cluster ls --profile profile_name

## For more
atlas config --help
atlas --help

## comands

atlas clusters search index list --clusterName Cluster_name --db db_name --collections collection_name
atlas clusters onlineArchives list --clusterName Cluster_name
atlas serveless create TestServerless --provider AWS --region US_EAST_1    (pay)

atlas cluster list

show collections
show dbs => shows the databases


db.help()