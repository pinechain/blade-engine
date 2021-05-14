source ./const/cnt_repo_index.sh

source ./config/cfg_defs.sh
source ./config/cfg_checkouts.sh

source ./const/cnt_repo_name.sh
source ./const/cnt_repo_url.sh
source ./const/cnt_folders.sh

source ./internal/int_checkout.sh

echo ""
echo "STEP 1/2: CREATING DIRECTORIES"

mkdir $ENVIRONMENT_ROOT

mkdir $BLADENG_ROOT
echo "BLADE ENGINE WORKSPACE CREATED!"
mkdir $GAMEDEV_ROOT
echo "GAMEDEV WORKSPACE CREATED!"
mkdir $ANDROID_ROOT
echo "ANDROID WORKSPACE CREATED!"

source ./internal/int_clone.sh

echo ""
echo "Development environment setup finished!"
echo "Have a nice day. :)"
echo ""

read -n 1 -s -r -p "Press any key to continue"